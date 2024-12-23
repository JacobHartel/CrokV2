namespace CrokV2
{
    public partial class Form1 : Form
    {

        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;
        public Form1()
        {
            InitializeComponent();

            //setting up context menu
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Settings", null, OnOpenSettingsClicked);
            trayMenu.Items.Add("Exit", null, OnExitClicked);

            //notifyIcon object
            trayIcon = new NotifyIcon();
            trayIcon.Text = "CrokV1";
            trayIcon.Icon = new Icon("jakethedog.ico"); 
            trayIcon.ContextMenuStrip = trayMenu;
            trayIcon.Visible = true;

            trayIcon.DoubleClick += (s, e) => ShowMainWindow();
            
        }

        private void ShowMainWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void OnOpenSettingsClicked(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            trayIcon.Dispose();
            base.OnFormClosing(e);
        }
    }
}
