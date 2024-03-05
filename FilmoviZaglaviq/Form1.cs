using Microsoft.VisualBasic.Devices;

namespace FilmoviZaglaviq
{
    public partial class Form1 : Form
    {
        Movie movie = new Movie();
        List<Movie> movies = new List<Movie>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           
            movie.Rejisior = txtRejisior.Text;
            movie.Title = txtZaglavie.Text;

            movie.Country = cmbCountry.Text;
            movie.Company = cmbCompany.Text;
            bool isallEntered = true;

            if (chbISokMinors.Checked)
            {
                movie.IsOkforminors = chbISokMinors.Text;
            }
            else
            {
                movie.IsOkforminors = "�� � ��������� �� ���� ��� 16 ������.";
                
            }

            if (string.IsNullOrEmpty(movie.Rejisior))
            {
                MessageBox.Show("�� �� ����� ��������!", "��������!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
                isallEntered = false;
                return;
            }

            if (string.IsNullOrEmpty(movie.Title))
            {
                MessageBox.Show("�� �� ����� ��������!", "��������!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isallEntered = false; 
                return;
            }

            if (string.IsNullOrEmpty(movie.Country))
            {
                MessageBox.Show("�� �� ����� �������!", "��������!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isallEntered = false;
                return;

            }

            if (string.IsNullOrEmpty(movie.Company))
            {
                MessageBox.Show("�� �� ����� ��������!", "��������!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isallEntered = false;
                return;
            }

            if (rdbAction.Checked)
            {
                movie.Genre = rdbAction.Text;
            }
            else
            if (rdbDrama.Checked)
            {
                movie.Genre = rdbDrama.Text;
            }
            else
            if (rdbHorror.Checked)
            {
                movie.Genre = rdbHorror.Text;
            }
            else
            if (rdbRomance.Checked)
            {
                movie.Genre = rdbRomance.Text;

            }
            else
            if (rdbTriller.Checked)
            {
                movie.Genre = rdbTriller.Text;

            }
            else
            {
                MessageBox.Show("�� �� ����� ����!", "��������!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isallEntered = false;
                return;
            }

            if (isallEntered)
            {
                DialogResult result = MessageBox.Show($"��� ���������:{movie.Title} � ��������:{movie.Rejisior} \n�������:{movie.Country} \n����:{movie.Genre} \n��������:{movie.Company} \n��������������:{movie.IsOkforminors}", "��������!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("��������!", "������� ��������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //movie = new Movie(movie.Rejisior, movie.Country, movie.Title, movie.Company, movie.Genre, movie.IsOkforminors);                   
                    movies.Add(movie);
                    
                }
            }
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{string.Join(" ",movies)}");
        }
    }
}
