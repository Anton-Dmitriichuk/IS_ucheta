using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;

        Word._Application application;
        Word._Document document;
        // DataSourceUpdateMode dsource;

        string sqlExpression_sp1 = "Прейскурант_по_виду_услуг";
        string sqlExpression_sp2 = "Add_in_contract";

        private SqlConnection connection = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=DESKTOP-86D962U;Initial Catalog=dmitriichuk_kp;Integrated Security=True";

        }

        private void add_client_button_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("add_client", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = client_name.Text;
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = client_surname.Text;
                command.Parameters.Add("@patronimyc", SqlDbType.NVarChar).Value = client_patronymic.Text;
                command.Parameters.Add("@contingent", SqlDbType.NVarChar).Value = client_contingent.Text;
                command.Parameters.Add("@date_of_birth", SqlDbType.Date).Value = client_date_of_birth.Text;
                command.Parameters.Add("@series_passport", SqlDbType.NVarChar).Value = client_series_passport.Text;
                command.Parameters.Add("@NumP", SqlDbType.NVarChar).Value = client_num_passport.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = client_address.Text;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = client_phone.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Новый клиент добавлен!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
                connection.Close();
            }

            add_in_contract.Enabled = true;
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            new_client_RB.Checked = true;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet12.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.dmitriichuk_kpDataSet12.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet11.Учет_платных_услуг". При необходимости она может быть перемещена или удалена.
            this.учет_платных_услугTableAdapter.Fill(this.dmitriichuk_kpDataSet11.Учет_платных_услуг);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet10.Raschet_skidki". При необходимости она может быть перемещена или удалена.
            this.raschet_skidkiTableAdapter.Fill(this.dmitriichuk_kpDataSet10.Raschet_skidki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet6.Реестр_специализаций". При необходимости она может быть перемещена или удалена.
            this.реестр_специализацийTableAdapter.Fill(this.dmitriichuk_kpDataSet6.Реестр_специализаций);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet5.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dmitriichuk_kpDataSet5.Должности);

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
            finally
            {
                MessageBox.Show("Подключение выполнено");
                connection.Close();
            }
            
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet3.Вид_услуги". При необходимости она может быть перемещена или удалена.
            this.вид_услугиTableAdapter.Fill(this.dmitriichuk_kpDataSet3.Вид_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet2.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.dmitriichuk_kpDataSet2.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dmitriichuk_kpDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dmitriichuk_kpDataSet.Сотрудники);

            patient_ex_dob_TB.MaxLength = 8;

        }

        // тут заполнение таблицы учет платных услуг по кнопке, брать данные из комбобоксов
        private void add_in_contract_Click(object sender, EventArgs e)
        {
            
        try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression_sp2, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@NumP", SqlDbType.NVarChar).Value = num_passport_ex_client_CB.Text;
                command.Parameters.Add("@surname_doctor", SqlDbType.NVarChar).Value = SN_doctor_CB.Text;
                command.Parameters.Add("@usluga", SqlDbType.NVarChar).Value = usluga_CB.Text;
                command.Parameters.Add("@type_name_uslugi", SqlDbType.NVarChar).Value = vid_uslugi_CB.Text;
                command.Parameters.Add("@doctor_position", SqlDbType.NVarChar).Value = doc_position_CB.Text;
                command.Parameters.Add("@specialization", SqlDbType.NVarChar).Value = specialization_doc_CB.Text;

                command.Parameters.Add("@scope_of_services", SqlDbType.NVarChar).Value = scope_uslug_TB.Text;
                command.Parameters.Add("@skidka", SqlDbType.NVarChar).Value = skidka_TB.Text;
                command.Parameters.Add("@cost", SqlDbType.NVarChar).Value = cost_TB.Text;
                command.Parameters.Add("@date_start", SqlDbType.Date).Value = Date_start_DTP.Text;
                command.Parameters.Add("@date_end", SqlDbType.Date).Value = Date_end_DTP.Text;

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Новая запись добавлена");

            }

            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("err" + ex);
            }
        }

        // Кнопка рассчитывающая стоимость
        private void FinCostRes_button_Click(object sender, EventArgs e)
        {
            try
            {
                string nump_client = num_passport_ex_client_CB.Text;
                string name_uslugi = usluga_CB.Text;

                SqlCommand command = new SqlCommand("Raschet_stoimosti", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@num_passport", SqlDbType.NVarChar).Value = nump_client;
                command.Parameters.Add("@name_uslugi", SqlDbType.NVarChar).Value = name_uslugi;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cost_TB.Text = reader.GetValue(3).ToString();
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("err" + ex);
            }

            if(new_client_RB.Checked == true)
            {
                try
                {
                    string name_uslugi = usluga_CB.Text;
                    int skidka = int.Parse(skidka_TB.Text);
                    string sqlquery = ($"SELECT  Цена_услуги FROM Услуги WHERE([Наименование_услуги] = @name_uslugi)");

                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlquery, connection);
                    command.Parameters.AddWithValue("@name_uslugi", name_uslugi);
                    SqlDataReader reader = command.ExecuteReader();
                    int cost;
                    if (reader.Read())
                    {
                        cost = int.Parse(reader.GetValue(0).ToString());
                        cost_TB.Text = (cost - (cost * skidka / 100)).ToString();
                    }

                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("err" + ex);
                }
            }
        }

        //Кнопка обновить на докторов
        private void UPD_doctor_button_Click(object sender, EventArgs e)
        {
            try
            {
                string surname_doctor = SN_doctor_CB.Text;
                string sqlquery = ($"SELECT  Имя, Отчество FROM Сотрудники WHERE([Фамилия] = @surname_doctor)");

                connection.Open();
                SqlCommand command = new SqlCommand(sqlquery, connection);
                command.Parameters.AddWithValue("@surname_doctor", surname_doctor);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    name_doctor_TB.Text = reader.GetValue(0).ToString();
                    otchestvo_doctor_TB.Text = reader.GetValue(1).ToString();
                    
                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
            }           
        }

        //Кнопка перелистывания докторов вправо
        private void change_doctor_button_plus_Click(object sender, EventArgs e)
        {
            int count_doctors = SN_doctor_CB.Items.Count;

            if (SN_doctor_CB.SelectedIndex < count_doctors - 1)
            {
                SN_doctor_CB.SelectedIndex += 1;
            }
            else
            {
                SN_doctor_CB.SelectedIndex = 0;
            }

            try
            {
                string surname_doctor = SN_doctor_CB.Text;
                string sqlquery = ($"SELECT  Имя, Отчество FROM Сотрудники WHERE([Фамилия] = @surname_doctor)");

                connection.Open();
                SqlCommand command = new SqlCommand(sqlquery, connection);
                command.Parameters.AddWithValue("@surname_doctor", surname_doctor);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    name_doctor_TB.Text = reader.GetValue(0).ToString();
                    otchestvo_doctor_TB.Text = reader.GetValue(1).ToString();

                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
            }
        }

        //Кнопка перелистывания докторов влево
        private void change_doctor_button_minus_Click(object sender, EventArgs e)
        {
            int count_doctors = SN_doctor_CB.Items.Count;

            if (SN_doctor_CB.SelectedIndex < count_doctors - 1 && SN_doctor_CB.SelectedIndex >= 1)
            {
                SN_doctor_CB.SelectedIndex -= 1;
            }

            else if (SN_doctor_CB.SelectedIndex == count_doctors - 1)
            {
                SN_doctor_CB.SelectedIndex -= 1;
            }

            else
            {
                SN_doctor_CB.SelectedIndex = count_doctors - 1;
            }

            try
            {
                string surname_doctor = SN_doctor_CB.Text;
                string sqlquery = ($"SELECT  Имя, Отчество FROM Сотрудники WHERE([Фамилия] = @surname_doctor)");

                connection.Open();
                SqlCommand command = new SqlCommand(sqlquery, connection);
                command.Parameters.AddWithValue("@surname_doctor", surname_doctor);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    name_doctor_TB.Text = reader.GetValue(0).ToString();
                    otchestvo_doctor_TB.Text = reader.GetValue(1).ToString();

                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
            }
        }

        // когда меняется номер паспорта в комбобоксе кнопка рассчитать стоимость становится неактивна
        private void num_passport_ex_client_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinCostRes_button.Enabled = false;
        }
     
        //смена между новым и сущ пациентом
        private void exist_client_RB_CheckedChanged(object sender, EventArgs e)
        {
            //существующий клиент
            if (exist_client_RB.Checked == true)
            {
                add_in_contract.Enabled = true;
                skidka_TB.Text = null;

                UPD_skidka_button.Text = "Обновить";
                add_client_button.Enabled = false;
                add_client_button.Visible = false;
                change_patient_button_minus.Enabled = true;
                change_patient_button_minus.Visible = true;
                change_patient_button_plus.Enabled = true;
                change_patient_button_plus.Visible = true;

                // убрать лэйблы добавить клиента
                client_address_text.Visible = false;
                client_contingent_text.Visible = false;
                client_date_of_birth_text.Visible = false;
                client_name_text.Visible = false;
                client_num_passport_text.Visible = false;
                client_patronymic_text.Visible = false;
                client_surname_text.Visible = false;
                client_series_passport_text.Visible = false;
                client_phone_text.Visible = false;

                // убрать текстбоксы добавить клиента
                client_address.Visible = false;
                client_contingent.Visible = false;
                client_date_of_birth.Visible = false;
                client_name.Visible = false;
                client_num_passport.Visible = false;
                client_patronymic.Visible = false;
                client_surname.Visible = false; 
                client_phone.Visible = false;
                client_series_passport.Visible = false;

                // деактивировать текстбоксы добавить клиента
                client_address.Enabled = false;
                client_contingent.Enabled = false;
                client_date_of_birth.Enabled = false;
                client_name.Enabled = false;
                client_num_passport.Enabled = false;
                client_patronymic.Enabled = false;
                client_surname.Enabled = false;
                client_phone.Enabled = false;
                client_series_passport.Enabled = false;

                // показать текстбоксы существующего клиента
                patient_contingent_text.Visible = true;
                patient_ex_contingent_TB.Visible = true;
                patient_name_text.Visible = true;
                patient_ex_name_TB.Visible = true;
                patient_surname_text.Visible = true;
                patient_ex_surname_TB.Visible = true;
                patient_patronimyc_text.Visible = true;
                patient_ex_patronimyc_TB.Visible = true;
                patient_num_passport.Visible = true;
                num_passport_ex_client_CB.Visible = true;
                patient_ex_dob_TB.Visible = true;
                patient_ex_address_TB.Visible = true;
                patient_address_text.Visible = true;
                patient_dob_text.Visible = true;

                // активировать текстбоксы существующего клиента
                patient_contingent_text.Enabled = true;
                patient_ex_contingent_TB.Enabled = true;
                patient_name_text.Enabled = true;
                patient_ex_name_TB.Enabled = true;
                patient_surname_text.Enabled = true;
                patient_ex_surname_TB.Enabled = true;
                patient_patronimyc_text.Enabled = true;
                patient_ex_patronimyc_TB.Enabled = true;
                patient_num_passport.Enabled = true;
                num_passport_ex_client_CB.Enabled = true;
                patient_ex_dob_TB.Enabled = true;
                patient_ex_address_TB.Enabled = true;
                patient_address_text.Enabled = true;
                patient_dob_text.Enabled = true;

            }
            // новый клиент
            else
            {

                add_in_contract.Enabled = false;
                skidka_TB.Text = null;

                UPD_skidka_button.Text = "Рассчитать скидку";
                add_client_button.Enabled = true;
                add_client_button.Visible = true;

                change_patient_button_minus.Enabled = false;
                change_patient_button_minus.Visible = false;
                change_patient_button_plus.Enabled = false;
                change_patient_button_plus.Visible = false;

                // показать лэйблы добавить клиента
                client_address_text.Visible = true;
                client_contingent_text.Visible = true;
                client_date_of_birth_text.Visible = true;
                client_name_text.Visible = true;
                client_num_passport_text.Visible = true;
                client_patronymic_text.Visible = true;
                client_surname_text.Visible = true;
                client_num_passport_text.Visible = true;
                client_phone_text.Visible = true;
                client_series_passport_text.Visible = true;

                // показать текстбоксы добавить клиента
                client_address.Visible = true;
                client_contingent.Visible = true;
                client_date_of_birth.Visible = true;
                client_name.Visible = true;
                client_num_passport.Visible = true;
                client_patronymic.Visible = true;
                client_surname.Visible = true;
                client_phone.Visible = true;
                client_series_passport.Visible = true;

                // активировать текстбоксы добавить клиента
                client_address.Enabled = true;
                client_contingent.Enabled = true;
                client_date_of_birth.Enabled = true;
                client_name.Enabled = true;
                client_num_passport.Enabled = true;
                client_patronymic.Enabled = true;
                client_surname.Enabled = true;
                client_phone.Enabled = true;
                client_series_passport.Enabled = true;

                // убрать текстбоксы существующего клиента
                patient_contingent_text.Visible = false;
                patient_ex_contingent_TB.Visible = false;
                patient_name_text.Visible = false;
                patient_ex_name_TB.Visible = false;
                patient_surname_text.Visible = false;
                patient_ex_surname_TB.Visible = false;
                patient_patronimyc_text.Visible = false;
                patient_ex_patronimyc_TB.Visible = false;
                patient_num_passport.Visible = false;
                num_passport_ex_client_CB.Visible = false;
                patient_ex_dob_TB.Visible = false;
                patient_ex_address_TB.Visible = false;
                patient_address_text.Visible = false;
                patient_dob_text.Visible = false;

                // деактивировать текстбоксы существующего клиента
                patient_contingent_text.Enabled = false;
                patient_ex_contingent_TB.Enabled = false;
                patient_name_text.Enabled = false;
                patient_ex_name_TB.Enabled = false;
                patient_surname_text.Enabled = false;
                patient_ex_surname_TB.Enabled = false;
                patient_patronimyc_text.Enabled = false;
                patient_ex_patronimyc_TB.Enabled = false;
                patient_num_passport.Enabled = false;
                num_passport_ex_client_CB.Enabled = false;
                patient_ex_dob_TB.Enabled = false;
                patient_ex_address_TB.Enabled = false;
                patient_address_text.Enabled = false;
                patient_dob_text.Enabled = false;

            }
        }

        // кнопка для расчета скидки сущ и новых пациентов
        private void UPD_skidka_button_Click_1(object sender, EventArgs e)
        {
            if (new_client_RB.Checked==true)
            {
                string contingent = client_contingent.Text.ToLower();

                switch (contingent) {
                    case "дмс":
                        skidka_TB.Text = "0"; 
                        break;

                    case "ветеран вов":
                        skidka_TB.Text = "50";
                        break;

                    case "инвалид 1 группы":
                        skidka_TB.Text = "40";
                        break;

                    case "инвалид 2 группы":
                        skidka_TB.Text = "45";
                        break;

                    case "инвалид 3 группы":
                        skidka_TB.Text = "50";
                        break;

                    case "пенсионер":
                        skidka_TB.Text = "50";
                        break;

                    default:
                        skidka_TB.Text = null; 
                        break;
                }
                if (skidka_TB != null)
                {
                    FinCostRes_button.Enabled = true;
                }
            }
            else
            {
                try
                {
                    string nump_client = num_passport_ex_client_CB.Text;
                    string sqlquery = ($"SELECT Скидка, Фамилия, Имя, Отчество, Контингент FROM Raschet_skidki WHERE([Номер_паспорта] = @nump_client)");

                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlquery, connection);
                    command.Parameters.AddWithValue("@nump_client", nump_client);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        skidka_TB.Text = reader.GetValue(0).ToString();
                        patient_ex_surname_TB.Text = reader.GetValue(1).ToString();
                        patient_ex_name_TB.Text = reader.GetValue(2).ToString();
                        patient_ex_patronimyc_TB.Text = reader.GetValue(3).ToString();
                        patient_ex_contingent_TB.Text = reader.GetValue(4).ToString();
                    }
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("err" + ex);
                }

                if (skidka_TB != null)
                {
                    FinCostRes_button.Enabled = true;
                }
            }
        }

        // листать существующих пациентов вправо
        private void change_patient_button_plus_Click(object sender, EventArgs e)
        {
            int count_patients = num_passport_ex_client_CB.Items.Count;

            if (num_passport_ex_client_CB.SelectedIndex < count_patients - 1)
            {
                num_passport_ex_client_CB.SelectedIndex += 1;
            }
            else
            {
                num_passport_ex_client_CB.SelectedIndex = 0;
            }

            try
            {
                string num_passport_patient = num_passport_ex_client_CB.Text;
                string sqlquery = ($"SELECT  Имя, Фамилия, Отчество, Дата_рождения, Адрес_проживания FROM Пациенты WHERE([Номер_паспорта] = @num_passport_patient)");

                connection.Open();
                SqlCommand command = new SqlCommand(sqlquery, connection);
                command.Parameters.AddWithValue("@num_passport_patient", num_passport_patient);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    patient_ex_name_TB.Text = reader.GetValue(0).ToString();
                    patient_ex_surname_TB.Text = reader.GetValue(1).ToString();
                    patient_ex_patronimyc_TB.Text = reader.GetValue(2).ToString();
                    patient_ex_dob_TB.Text= reader.GetValue(3).ToString().Substring(0, 10);
                    patient_ex_address_TB.Text =reader.GetValue(4).ToString();
                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
            }

        }

        // листать существующих пациентов влево
        private void change_patient_button_minus_Click(object sender, EventArgs e)
        {
            int count_patients = num_passport_ex_client_CB.Items.Count;

            if (num_passport_ex_client_CB.SelectedIndex < count_patients - 1 && num_passport_ex_client_CB.SelectedIndex >= 1)
            {
                num_passport_ex_client_CB.SelectedIndex -= 1;
            }

            else if (num_passport_ex_client_CB.SelectedIndex == count_patients - 1)
            {
                num_passport_ex_client_CB.SelectedIndex -= 1;
            }

            else
            {
                num_passport_ex_client_CB.SelectedIndex = count_patients - 1;
            }

            try
            {
                string num_passport_patient = num_passport_ex_client_CB.Text;
                string sqlquery = ($"SELECT  Имя, Фамилия, Отчество, Дата_рождения, Адрес_проживания FROM Пациенты WHERE([Номер_паспорта] = @num_passport_patient)");

                connection.Open();
                SqlCommand command = new SqlCommand(sqlquery, connection);
                command.Parameters.AddWithValue("@num_passport_patient", num_passport_patient);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    patient_ex_name_TB.Text = reader.GetValue(0).ToString();
                    patient_ex_surname_TB.Text = reader.GetValue(1).ToString();
                    patient_ex_patronimyc_TB.Text = reader.GetValue(2).ToString();
                    patient_ex_dob_TB.Text = reader.GetValue(3).ToString().Substring(0, 10);
                    patient_ex_address_TB.Text = reader.GetValue(4).ToString();

                }
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
            }
        }

        private void UPD_podchinennaya_forma_Click(object sender, EventArgs e)
        {

            string numpassportPatient = num_passport_ex_client_CB.Text;

            try
            {
                connection.Open();

                // Создаем SQL-команду для выборки данных из представления
                string query = $"SELECT * FROM Contracts WHERE [Номер\\Серия паспорта] LIKE ('{numpassportPatient}%')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Используем SqlDataAdapter для заполнения DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Заполняем DataGridView данными из DataTable
                    Podchinennaya_forma.DataSource = dataTable;
                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Месяц, Количество_за_период from MonthStatistic", connection);
            adapter.Fill(dt);
            chart1.DataSource = dt;
            connection.Close();

            chart1.Series["Услуги"].XValueMember = "Месяц";
            chart1.Series["Услуги"].YValueMembers = "Количество_за_период";
            chart1.Titles.Clear();
            chart1.Titles.Add("Количество предоставленных услуг по месяцам");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Месяц, Рублей_в_месяц from ProfitPerMonth", connection);
            adapter.Fill(dt);
            chart1.DataSource = dt;
            connection.Close();

            chart1.Series["Услуги"].XValueMember = "Месяц";
            chart1.Series["Услуги"].YValueMembers = "Рублей_в_месяц";
            chart1.Titles.Clear();
            chart1.Titles.Add("Сумма денежных средств, заработанных на предоставлении услуг");
        }

        private void Create_contract_btn_Click(object sender, EventArgs e)
        {
            string numpassportPatient;
            string id_contract;
            string datestart;
            string cost;
            string FIO;
            string Passport;
            string Address;

            if (new_client_RB.Checked == true)
            {
                numpassportPatient = client_num_passport.Text;
            }
            else
            {
                numpassportPatient = num_passport_ex_client_CB.Text;
            }

            connection.Open();

            // Создаем SQL-команду для выборки данных из представления
            string query = $"SELECT * FROM Contracts WHERE [Номер\\Серия паспорта] LIKE ('{numpassportPatient}%')" +
                           $" AND [Дата заключения договора] = CONVERT(date, GETDATE())";
            SqlCommand command = new SqlCommand(query, connection);
                
            // Используем SqlDataAdapter для заполнения DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            id_contract = dataTable.Rows[0]["Номер_договора"].ToString();
            datestart = dataTable.Rows[0]["Дата заключения договора"].ToString();
            cost = dataTable.Rows[0]["Итоговая стоимость"].ToString();
            FIO = dataTable.Rows[0]["ФИО пациента"].ToString();
            Passport = dataTable.Rows[0]["Номер\\Серия паспорта"].ToString();
            Address = dataTable.Rows[0]["Адрес проживания"].ToString();

            connection.Close();

            Word.Document doc = null;

            try
            {
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = @"C:\Users\Антон Дмитрийчук\Desktop\интерфейсы\WindowsFormsApp1\documentation\Contract.docx";
                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();

                // Добавляем информацию
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                string[] data = new string[6] { Address, datestart, id_contract, Passport, FIO, cost };
                foreach (Word.Bookmark mark in wBookmarks)
                {
                    wRange = mark.Range;
                    wRange.Text = data[i];
                    i++;
                }

                // Закрываем документ
                doc.Close();
                doc = null;

                MessageBox.Show("Договор сформирован! Откройте документ.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("fewr" + ex);
            }
        }

        private void Create_akt_btn_Click(object sender, EventArgs e)
        {
            string numpassportPatient;
            string id_contract;
            string datestart;
            string cost;
            string FIO;
            string names;
            string Address;
            if (new_client_RB.Checked == true)
            { numpassportPatient = client_num_passport.Text; }
            else
            { numpassportPatient = num_passport_ex_client_CB.Text; }
            connection.Open();
            string query = $"SELECT * FROM Contracts WHERE [Номер\\Серия паспорта] LIKE ('{numpassportPatient}%')" +
                           $" AND [Дата заключения договора] = CONVERT(date, GETDATE())";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            id_contract = dataTable.Rows[0]["Номер_договора"].ToString();
            datestart = dataTable.Rows[0]["Дата заключения договора"].ToString();
            cost = dataTable.Rows[0]["Итоговая стоимость"].ToString();
            FIO = dataTable.Rows[0]["ФИО пациента"].ToString();
            Address = dataTable.Rows[0]["Адрес проживания"].ToString();
            names = dataTable.Rows[0]["Заказанные услуги"].ToString();
            connection.Close();

            Word.Document doc = null;
            try
            {
                Word.Application app = new Word.Application();
                string source = @"C:\Users\Антон Дмитрийчук\Desktop\интерфейсы\WindowsFormsApp1\documentation\Akt.docx";
                doc = app.Documents.Open(source);
                doc.Activate();
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                string[] data = new string[14] { Address, datestart, datestart, datestart, datestart, datestart, cost, cost, id_contract, id_contract, id_contract, names, FIO, FIO };
                foreach (Word.Bookmark mark in wBookmarks)
                { wRange = mark.Range;
                  wRange.Text = data[i];
                  i++; }
                doc.Close();
                doc = null;
                MessageBox.Show("Акт сформирован! Откройте документ.");
            }
            catch (Exception ex)
            { MessageBox.Show("error" + ex); }
        }
        
    
    }
}
