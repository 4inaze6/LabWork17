namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles("*", SearchOption.AllDirectories);
        }

        private void TaskButton1_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new { file.Name, file.FullName, file.Length, file.CreationTime })
                .OrderBy(file => file.Name)
                .ThenByDescending(file => file.CreationTime);
            dataGridView.DataSource = files.ToList();
        }

        private void TaskButton2_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new { file.Extension })
                .Distinct();
            dataGridView.DataSource = files.ToList();
        }

        private void TaskButton3_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .GroupBy(file => file.Extension)
                .Select(group => new
                {
                    Extension = group.Key,
                    Count = group.Count()
                });
            dataGridView.DataSource = files.ToList();
        }

        private void TaskButton4_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
               .Where(file => file.Name.Contains(fileNameTextBox.Text));
            dataGridView.DataSource = files.ToList();
        }

        private void TaskButton5_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Where(file => file.CreationTime.Day == DateTime.Today.Day)
                .OrderByDescending(file => file.CreationTime)
                .Take(5);
            dataGridView.DataSource = files.ToList();
        }

        private void TaskButton6_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new
                {
                    Count = GetFiles(directoryTextBox.Text)
                    .Count(),
                    LengthInMb = GetFiles(directoryTextBox.Text)
                    .Sum(file => file.Length) / (1024 * 1024)
                })
                .Distinct();

            dataGridView.DataSource = files.ToList();
        }

        private void TaskButton7_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new
                {
                    file.Name,
                    file.Extension,
                    file.FullName,
                    Length = (file.Length < (1 << 10)) ? $"{file.Length} ม" : (file.Length < (1 << 20)) ? $"{file.Length/1024} สม" : $"{file.Length/(1024*1024)} ฬม"
                });
            dataGridView.DataSource = files.ToList();
        }

        private void TaskButton8_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                 .Select(file => new
                 {
                     Count = GetFiles(directoryTextBox.Text)
                    .Count(file => file.Name == fileNameTextBox.Text)
                 })
                 .Distinct();
            dataGridView.DataSource = files.ToList();
        }
    }
}
