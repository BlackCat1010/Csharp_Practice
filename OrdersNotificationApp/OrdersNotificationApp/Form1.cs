using C_OrdersNotificationApp;

namespace OrdersNotificationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeApplicationItems(this.Width, this.Height);
        }

        public void InitializeApplicationItems(int parentWidth, int parentHeight)
        {
            // Initialize TextBox
            MyTextBox LogBox = new MyTextBox(parentWidth, parentHeight);
            Controls.Add(LogBox);

            // Create and initialize a Button.
            MyButton ProcessButton = new MyButton();
            Controls.Add(ProcessButton);

            EventsBootStrapper _start = new EventsBootStrapper(ProcessButton, LogBox);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            ClientSize = new Size(665, 400);
            Name = "Form1";
            ResumeLayout(false);

        }
    }
}
