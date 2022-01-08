using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;

namespace OriginValidMailChecker
{
    public partial class Checker : Form
    {
        public Checker()
        {
            InitializeComponent();
            ThreadLabelValue.Text = ThreadBar.Value.ToString();
            CheckForIllegalCrossThreadCalls = false;
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Results\\");
        }

        string date = DateTime.Now.ToString("dd-MM-yyyy");

        public int ValidEmails = 0;
        public int InvalidEmails = 0;
        public int CheckedEmails = 0;
        public int ProxyErrors = 0;

        public string[] Emails;
        public string[] Proxies;

        private void WriteToFile(string email)
        {
            string fileName = Environment.CurrentDirectory + @"\\Results\\ [Valid Emails] " + date + ".txt";
            File.AppendAllText(fileName, email + Environment.NewLine);
        }

        private void ThreadBar_ValueChanged(object sender, EventArgs e)
        {
            ThreadLabelValue.Text = ThreadBar.Value.ToString();
        }

        private void LoadEmailButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Emails |*.txt";
            openfile.Title = "Load Your Emails";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Emails = File.ReadAllLines(openfile.FileName.ToString());
                LoadedEmailValue.Text = Emails.Length.ToString();
            }
        }

        private void LoadProxiesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Proxies |*.txt";
            openfile.Title = "Load Your Proxies";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Proxies = File.ReadAllLines(openfile.FileName.ToString());
                LoadedProxyValue.Text = Proxies.Length.ToString();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(SeperateThread);
            thread.Start();
            thread.IsBackground = true;
        }

        public string RandomProxy()
        {
            Random rand = new Random();
            int pindex = rand.Next(Proxies.Length);

            return Proxies[pindex];
        }

        private void EmailChecker(string email)
        {
            string originurl = $"https://signin.ea.com/p/ajax/user/checkEmailExisted?requestorId=portal&email={email}";

            HttpRequest request = new HttpRequest();
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36";

            while (true)
            {
                if (HTTPToggle.Checked)
                {
                    request.Proxy = HttpProxyClient.Parse(RandomProxy());
                }
                else if (SOCKS4Toggle.Checked)
                {
                    request.Proxy = Socks4ProxyClient.Parse(RandomProxy());
                }
                else if (SOCKS5Toggle.Checked)
                {
                    request.Proxy = Socks5ProxyClient.Parse(RandomProxy());
                }
                else if (ProxylessToggle.Checked)
                {
                    try
                    {
                        string response = request.Get(originurl).ToString();
                        if (response.Contains("register_email_existed"))
                        {
                            ValidEmails += 1;
                            CheckedEmails += 1;

                            ValidEmailValue.Text = ValidEmails.ToString();
                            CheckedEmailValue.Text = CheckedEmails.ToString();

                            string[] Valids = { email };
                            var ListItem = new ListViewItem(Valids);
                            ResultListView.Items.Add(ListItem);

                            WriteToFile(email);
                            break;
                        }
                        else
                        {
                            InvalidEmails += 1;
                            CheckedEmails += 1;

                            InvalidEmailValue.Text = InvalidEmails.ToString();
                            CheckedEmailValue.Text = CheckedEmails.ToString();
                        }
                    }
                    catch (HttpException ex)
                    {
                        if (ex.Status.Equals(HttpExceptionStatus.ConnectFailure))
                        {
                            ProxyErrors += 1;
                            ErrorValue.Text = ProxyErrors.ToString();
                        }
                    }
                }
                try
                {
                    string response = request.Get(originurl).ToString();
                    if (response.Contains("register_email_existed"))
                    {
                        ValidEmails += 1;
                        CheckedEmails += 1;

                        ValidEmailValue.Text = ValidEmails.ToString();
                        CheckedEmailValue.Text = CheckedEmails.ToString();

                        string[] Valids = { email };
                        var ListItem = new ListViewItem(Valids);
                        ResultListView.Items.Add(ListItem);

                        WriteToFile(email);
                        break;
                    }
                    else
                    {
                        InvalidEmails += 1;
                        CheckedEmails += 1;

                        InvalidEmailValue.Text = InvalidEmails.ToString();
                        CheckedEmailValue.Text = CheckedEmails.ToString();
                    }
                }
                catch (HttpException ex)
                {
                    if (ex.Status.Equals(HttpExceptionStatus.ConnectFailure))
                    {
                        ProxyErrors += 1;
                        ErrorValue.Text = ProxyErrors.ToString();
                    }
                }
            }
        }

        private void SeperateThread()
        {
            Parallel.ForEach(
                Emails,
                new ParallelOptions
                {
                    MaxDegreeOfParallelism = Convert.ToInt32(ThreadBar.Value)
                },
                Emails =>
                {
                    EmailChecker(Emails);
                });
        }
    }
}
