
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Contract_page = new System.Windows.Forms.TabPage();
            this.UPD_podchinennaya_forma = new System.Windows.Forms.Button();
            this.Create_contract_btn = new System.Windows.Forms.Button();
            this.Create_akt_btn = new System.Windows.Forms.Button();
            this.Create_smeta_btn = new System.Windows.Forms.Button();
            this.Podchinennaya_forma = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.change_doctor_button_minus = new System.Windows.Forms.Button();
            this.specialization_doc_CB = new System.Windows.Forms.ComboBox();
            this.реестрспециализацийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet6 = new WindowsFormsApp1.dmitriichuk_kpDataSet6();
            this.specialization_doc_label = new System.Windows.Forms.Label();
            this.change_doctor_button_plus = new System.Windows.Forms.Button();
            this.doc_position_CB = new System.Windows.Forms.ComboBox();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet5 = new WindowsFormsApp1.dmitriichuk_kpDataSet5();
            this.UPD_doctor_button = new System.Windows.Forms.Button();
            this.otchestvo_doctor_TB = new System.Windows.Forms.TextBox();
            this.name_doctor_TB = new System.Windows.Forms.TextBox();
            this.position_doc_label = new System.Windows.Forms.Label();
            this.SN_doctor_CB = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet = new WindowsFormsApp1.dmitriichuk_kpDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surname_doc_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_in_contract = new System.Windows.Forms.Button();
            this.FinCostRes_button = new System.Windows.Forms.Button();
            this.cost_TB = new System.Windows.Forms.TextBox();
            this.Date_end_DTP = new System.Windows.Forms.DateTimePicker();
            this.Date_start_DTP = new System.Windows.Forms.DateTimePicker();
            this.scope_uslug_TB = new System.Windows.Forms.TextBox();
            this.vid_uslugi_CB = new System.Windows.Forms.ComboBox();
            this.видуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet3 = new WindowsFormsApp1.dmitriichuk_kpDataSet3();
            this.usluga_CB = new System.Windows.Forms.ComboBox();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet12 = new WindowsFormsApp1.dmitriichuk_kpDataSet12();
            this.type_uslugi_label = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Date_start_label = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cost_service_label = new System.Windows.Forms.Label();
            this.scope_services_label = new System.Windows.Forms.Label();
            this.name_uslugi_label = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.client_contingent = new System.Windows.Forms.ComboBox();
            this.change_patient_button_minus = new System.Windows.Forms.Button();
            this.patient_ex_address_TB = new System.Windows.Forms.TextBox();
            this.patient_ex_contingent_TB = new System.Windows.Forms.TextBox();
            this.change_patient_button_plus = new System.Windows.Forms.Button();
            this.patient_ex_patronimyc_TB = new System.Windows.Forms.TextBox();
            this.patient_ex_name_TB = new System.Windows.Forms.TextBox();
            this.patient_address_text = new System.Windows.Forms.Label();
            this.patient_ex_surname_TB = new System.Windows.Forms.TextBox();
            this.patient_dob_text = new System.Windows.Forms.Label();
            this.patient_contingent_text = new System.Windows.Forms.Label();
            this.patient_patronimyc_text = new System.Windows.Forms.Label();
            this.patient_name_text = new System.Windows.Forms.Label();
            this.patient_surname_text = new System.Windows.Forms.Label();
            this.patient_num_passport = new System.Windows.Forms.Label();
            this.num_passport_ex_client_CB = new System.Windows.Forms.ComboBox();
            this.пациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet2 = new WindowsFormsApp1.dmitriichuk_kpDataSet2();
            this.exist_client_RB = new System.Windows.Forms.RadioButton();
            this.new_client_RB = new System.Windows.Forms.RadioButton();
            this.UPD_skidka_button = new System.Windows.Forms.Button();
            this.skidka_TB = new System.Windows.Forms.TextBox();
            this.skidka_label = new System.Windows.Forms.Label();
            this.client_phone_text = new System.Windows.Forms.Label();
            this.add_client_button = new System.Windows.Forms.Button();
            this.client_contingent_text = new System.Windows.Forms.Label();
            this.client_patronymic_text = new System.Windows.Forms.Label();
            this.client_phone = new System.Windows.Forms.TextBox();
            this.client_address_text = new System.Windows.Forms.Label();
            this.client_surname_text = new System.Windows.Forms.Label();
            this.client_date_of_birth_text = new System.Windows.Forms.Label();
            this.client_name_text = new System.Windows.Forms.Label();
            this.client_num_passport_text = new System.Windows.Forms.Label();
            this.client_patronymic = new System.Windows.Forms.TextBox();
            this.client_series_passport_text = new System.Windows.Forms.Label();
            this.client_surname = new System.Windows.Forms.TextBox();
            this.client_name = new System.Windows.Forms.TextBox();
            this.client_num_passport = new System.Windows.Forms.TextBox();
            this.client_series_passport = new System.Windows.Forms.TextBox();
            this.client_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.patient_ex_dob_TB = new System.Windows.Forms.TextBox();
            this.client_address = new System.Windows.Forms.TextBox();
            this.Statistic = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.учетплатныхуслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet11 = new WindowsFormsApp1.dmitriichuk_kpDataSet11();
            this.прейскурантповидууслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet4 = new WindowsFormsApp1.dmitriichuk_kpDataSet4();
            this.patientsSurNameSerPNumPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet1 = new WindowsFormsApp1.dmitriichuk_kpDataSet1();
            this.raschetskidkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet10 = new WindowsFormsApp1.dmitriichuk_kpDataSet10();
            this.statisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmitriichuk_kpDataSet9 = new WindowsFormsApp1.dmitriichuk_kpDataSet9();
            this.сотрудникиTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSetTableAdapters.СотрудникиTableAdapter();
            this.patients_SurName_SerP_NumPTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet1TableAdapters.Patients_SurName_SerP_NumPTableAdapter();
            this.пациентыTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet2TableAdapters.ПациентыTableAdapter();
            this.вид_услугиTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet3TableAdapters.Вид_услугиTableAdapter();
            this.прейскурант_по_виду_услугTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet4TableAdapters.Прейскурант_по_виду_услугTableAdapter();
            this.должностиTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet5TableAdapters.ДолжностиTableAdapter();
            this.реестр_специализацийTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet6TableAdapters.Реестр_специализацийTableAdapter();
            this.dmitriichuk_kpDataSet8 = new WindowsFormsApp1.dmitriichuk_kpDataSet8();
            this.dmitriichukkpDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statisticTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet9TableAdapters.StatisticTableAdapter();
            this.raschet_skidkiTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet10TableAdapters.Raschet_skidkiTableAdapter();
            this.учет_платных_услугTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet11TableAdapters.Учет_платных_услугTableAdapter();
            this.услугиTableAdapter = new WindowsFormsApp1.dmitriichuk_kpDataSet12TableAdapters.УслугиTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Contract_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Podchinennaya_forma)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.реестрспециализацийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видуслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet12)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet2)).BeginInit();
            this.Statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетплатныхуслугBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прейскурантповидууслугBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsSurNameSerPNumPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raschetskidkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichukkpDataSet8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Contract_page);
            this.tabControl1.Controls.Add(this.Statistic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1436, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // Contract_page
            // 
            this.Contract_page.Controls.Add(this.UPD_podchinennaya_forma);
            this.Contract_page.Controls.Add(this.Create_contract_btn);
            this.Contract_page.Controls.Add(this.Create_akt_btn);
            this.Contract_page.Controls.Add(this.Create_smeta_btn);
            this.Contract_page.Controls.Add(this.Podchinennaya_forma);
            this.Contract_page.Controls.Add(this.groupBox1);
            this.Contract_page.Controls.Add(this.groupBox2);
            this.Contract_page.Controls.Add(this.groupBox4);
            this.Contract_page.Location = new System.Drawing.Point(4, 22);
            this.Contract_page.Name = "Contract_page";
            this.Contract_page.Padding = new System.Windows.Forms.Padding(3);
            this.Contract_page.Size = new System.Drawing.Size(1428, 626);
            this.Contract_page.TabIndex = 0;
            this.Contract_page.Text = "Заключение договора";
            this.Contract_page.UseVisualStyleBackColor = true;
            // 
            // UPD_podchinennaya_forma
            // 
            this.UPD_podchinennaya_forma.Location = new System.Drawing.Point(1261, 324);
            this.UPD_podchinennaya_forma.Name = "UPD_podchinennaya_forma";
            this.UPD_podchinennaya_forma.Size = new System.Drawing.Size(123, 26);
            this.UPD_podchinennaya_forma.TabIndex = 17;
            this.UPD_podchinennaya_forma.Text = "Договоры";
            this.UPD_podchinennaya_forma.UseVisualStyleBackColor = true;
            this.UPD_podchinennaya_forma.Click += new System.EventHandler(this.UPD_podchinennaya_forma_Click);
            // 
            // Create_contract_btn
            // 
            this.Create_contract_btn.Location = new System.Drawing.Point(966, 563);
            this.Create_contract_btn.Name = "Create_contract_btn";
            this.Create_contract_btn.Size = new System.Drawing.Size(123, 44);
            this.Create_contract_btn.TabIndex = 17;
            this.Create_contract_btn.Text = "Сформировать договор";
            this.Create_contract_btn.UseVisualStyleBackColor = true;
            this.Create_contract_btn.Click += new System.EventHandler(this.Create_contract_btn_Click);
            // 
            // Create_akt_btn
            // 
            this.Create_akt_btn.Location = new System.Drawing.Point(1114, 563);
            this.Create_akt_btn.Name = "Create_akt_btn";
            this.Create_akt_btn.Size = new System.Drawing.Size(123, 44);
            this.Create_akt_btn.TabIndex = 17;
            this.Create_akt_btn.Text = "Сформировать Акт сдачи-приемки";
            this.Create_akt_btn.UseVisualStyleBackColor = true;
            this.Create_akt_btn.Click += new System.EventHandler(this.Create_akt_btn_Click);
            // 
            // Create_smeta_btn
            // 
            this.Create_smeta_btn.Location = new System.Drawing.Point(1261, 563);
            this.Create_smeta_btn.Name = "Create_smeta_btn";
            this.Create_smeta_btn.Size = new System.Drawing.Size(123, 44);
            this.Create_smeta_btn.TabIndex = 17;
            this.Create_smeta_btn.Text = "Сформировать смету";
            this.Create_smeta_btn.UseVisualStyleBackColor = true;
            // 
            // Podchinennaya_forma
            // 
            this.Podchinennaya_forma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Podchinennaya_forma.Location = new System.Drawing.Point(6, 356);
            this.Podchinennaya_forma.Name = "Podchinennaya_forma";
            this.Podchinennaya_forma.Size = new System.Drawing.Size(1378, 196);
            this.Podchinennaya_forma.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.change_doctor_button_minus);
            this.groupBox1.Controls.Add(this.specialization_doc_CB);
            this.groupBox1.Controls.Add(this.specialization_doc_label);
            this.groupBox1.Controls.Add(this.change_doctor_button_plus);
            this.groupBox1.Controls.Add(this.doc_position_CB);
            this.groupBox1.Controls.Add(this.UPD_doctor_button);
            this.groupBox1.Controls.Add(this.otchestvo_doctor_TB);
            this.groupBox1.Controls.Add(this.name_doctor_TB);
            this.groupBox1.Controls.Add(this.position_doc_label);
            this.groupBox1.Controls.Add(this.SN_doctor_CB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.surname_doc_label);
            this.groupBox1.Location = new System.Drawing.Point(500, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 141);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные лечащего врача";
            // 
            // change_doctor_button_minus
            // 
            this.change_doctor_button_minus.Location = new System.Drawing.Point(231, 110);
            this.change_doctor_button_minus.Name = "change_doctor_button_minus";
            this.change_doctor_button_minus.Size = new System.Drawing.Size(22, 23);
            this.change_doctor_button_minus.TabIndex = 19;
            this.change_doctor_button_minus.Text = "<";
            this.change_doctor_button_minus.UseVisualStyleBackColor = true;
            this.change_doctor_button_minus.Click += new System.EventHandler(this.change_doctor_button_minus_Click);
            // 
            // specialization_doc_CB
            // 
            this.specialization_doc_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.specialization_doc_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.specialization_doc_CB.DataSource = this.реестрспециализацийBindingSource;
            this.specialization_doc_CB.DisplayMember = "Наименование_специализации";
            this.specialization_doc_CB.FormattingEnabled = true;
            this.specialization_doc_CB.Location = new System.Drawing.Point(566, 53);
            this.specialization_doc_CB.Name = "specialization_doc_CB";
            this.specialization_doc_CB.Size = new System.Drawing.Size(245, 21);
            this.specialization_doc_CB.TabIndex = 3;
            // 
            // реестрспециализацийBindingSource
            // 
            this.реестрспециализацийBindingSource.DataMember = "Реестр_специализаций";
            this.реестрспециализацийBindingSource.DataSource = this.dmitriichuk_kpDataSet6;
            // 
            // dmitriichuk_kpDataSet6
            // 
            this.dmitriichuk_kpDataSet6.DataSetName = "dmitriichuk_kpDataSet6";
            this.dmitriichuk_kpDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialization_doc_label
            // 
            this.specialization_doc_label.AutoSize = true;
            this.specialization_doc_label.Location = new System.Drawing.Point(474, 56);
            this.specialization_doc_label.Name = "specialization_doc_label";
            this.specialization_doc_label.Size = new System.Drawing.Size(86, 13);
            this.specialization_doc_label.TabIndex = 2;
            this.specialization_doc_label.Text = "Специализация";
            // 
            // change_doctor_button_plus
            // 
            this.change_doctor_button_plus.Location = new System.Drawing.Point(297, 110);
            this.change_doctor_button_plus.Name = "change_doctor_button_plus";
            this.change_doctor_button_plus.Size = new System.Drawing.Size(21, 23);
            this.change_doctor_button_plus.TabIndex = 19;
            this.change_doctor_button_plus.Text = ">";
            this.change_doctor_button_plus.UseVisualStyleBackColor = true;
            this.change_doctor_button_plus.Click += new System.EventHandler(this.change_doctor_button_plus_Click);
            // 
            // doc_position_CB
            // 
            this.doc_position_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.doc_position_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doc_position_CB.DataSource = this.должностиBindingSource;
            this.doc_position_CB.DisplayMember = "Наименование_должности";
            this.doc_position_CB.FormattingEnabled = true;
            this.doc_position_CB.Location = new System.Drawing.Point(566, 26);
            this.doc_position_CB.Name = "doc_position_CB";
            this.doc_position_CB.Size = new System.Drawing.Size(245, 21);
            this.doc_position_CB.TabIndex = 3;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.dmitriichuk_kpDataSet5;
            // 
            // dmitriichuk_kpDataSet5
            // 
            this.dmitriichuk_kpDataSet5.DataSetName = "dmitriichuk_kpDataSet5";
            this.dmitriichuk_kpDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UPD_doctor_button
            // 
            this.UPD_doctor_button.Location = new System.Drawing.Point(113, 110);
            this.UPD_doctor_button.Name = "UPD_doctor_button";
            this.UPD_doctor_button.Size = new System.Drawing.Size(112, 23);
            this.UPD_doctor_button.TabIndex = 16;
            this.UPD_doctor_button.Text = "Обновить";
            this.UPD_doctor_button.UseVisualStyleBackColor = true;
            this.UPD_doctor_button.Click += new System.EventHandler(this.UPD_doctor_button_Click);
            // 
            // otchestvo_doctor_TB
            // 
            this.otchestvo_doctor_TB.Location = new System.Drawing.Point(113, 82);
            this.otchestvo_doctor_TB.Name = "otchestvo_doctor_TB";
            this.otchestvo_doctor_TB.ReadOnly = true;
            this.otchestvo_doctor_TB.Size = new System.Drawing.Size(205, 20);
            this.otchestvo_doctor_TB.TabIndex = 17;
            // 
            // name_doctor_TB
            // 
            this.name_doctor_TB.Location = new System.Drawing.Point(113, 54);
            this.name_doctor_TB.Name = "name_doctor_TB";
            this.name_doctor_TB.ReadOnly = true;
            this.name_doctor_TB.Size = new System.Drawing.Size(205, 20);
            this.name_doctor_TB.TabIndex = 17;
            // 
            // position_doc_label
            // 
            this.position_doc_label.AutoSize = true;
            this.position_doc_label.Location = new System.Drawing.Point(492, 29);
            this.position_doc_label.Name = "position_doc_label";
            this.position_doc_label.Size = new System.Drawing.Size(68, 13);
            this.position_doc_label.TabIndex = 2;
            this.position_doc_label.Text = "Должность ";
            // 
            // SN_doctor_CB
            // 
            this.SN_doctor_CB.DataSource = this.сотрудникиBindingSource;
            this.SN_doctor_CB.DisplayMember = "Фамилия";
            this.SN_doctor_CB.FormattingEnabled = true;
            this.SN_doctor_CB.Location = new System.Drawing.Point(113, 25);
            this.SN_doctor_CB.Name = "SN_doctor_CB";
            this.SN_doctor_CB.Size = new System.Drawing.Size(205, 21);
            this.SN_doctor_CB.TabIndex = 3;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.dmitriichuk_kpDataSet;
            // 
            // dmitriichuk_kpDataSet
            // 
            this.dmitriichuk_kpDataSet.DataSetName = "dmitriichuk_kpDataSet";
            this.dmitriichuk_kpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Имя";
            // 
            // surname_doc_label
            // 
            this.surname_doc_label.AutoSize = true;
            this.surname_doc_label.Location = new System.Drawing.Point(48, 28);
            this.surname_doc_label.Name = "surname_doc_label";
            this.surname_doc_label.Size = new System.Drawing.Size(59, 13);
            this.surname_doc_label.TabIndex = 2;
            this.surname_doc_label.Text = "Фамилия ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.add_in_contract);
            this.groupBox2.Controls.Add(this.FinCostRes_button);
            this.groupBox2.Controls.Add(this.cost_TB);
            this.groupBox2.Controls.Add(this.Date_end_DTP);
            this.groupBox2.Controls.Add(this.Date_start_DTP);
            this.groupBox2.Controls.Add(this.scope_uslug_TB);
            this.groupBox2.Controls.Add(this.vid_uslugi_CB);
            this.groupBox2.Controls.Add(this.usluga_CB);
            this.groupBox2.Controls.Add(this.type_uslugi_label);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.Date_start_label);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.cost_service_label);
            this.groupBox2.Controls.Add(this.scope_services_label);
            this.groupBox2.Controls.Add(this.name_uslugi_label);
            this.groupBox2.Location = new System.Drawing.Point(500, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 165);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об услугах";
            // 
            // add_in_contract
            // 
            this.add_in_contract.Enabled = false;
            this.add_in_contract.Location = new System.Drawing.Point(688, 119);
            this.add_in_contract.Name = "add_in_contract";
            this.add_in_contract.Size = new System.Drawing.Size(123, 25);
            this.add_in_contract.TabIndex = 17;
            this.add_in_contract.Text = "Добавить в договор";
            this.add_in_contract.UseVisualStyleBackColor = true;
            this.add_in_contract.Click += new System.EventHandler(this.add_in_contract_Click);
            // 
            // FinCostRes_button
            // 
            this.FinCostRes_button.Enabled = false;
            this.FinCostRes_button.Location = new System.Drawing.Point(324, 121);
            this.FinCostRes_button.Name = "FinCostRes_button";
            this.FinCostRes_button.Size = new System.Drawing.Size(130, 23);
            this.FinCostRes_button.TabIndex = 16;
            this.FinCostRes_button.Text = "Рассчитать стоимость";
            this.FinCostRes_button.UseVisualStyleBackColor = true;
            this.FinCostRes_button.Click += new System.EventHandler(this.FinCostRes_button_Click);
            // 
            // cost_TB
            // 
            this.cost_TB.BackColor = System.Drawing.SystemColors.Info;
            this.cost_TB.Location = new System.Drawing.Point(215, 122);
            this.cost_TB.Name = "cost_TB";
            this.cost_TB.ReadOnly = true;
            this.cost_TB.Size = new System.Drawing.Size(73, 20);
            this.cost_TB.TabIndex = 10;
            // 
            // Date_end_DTP
            // 
            this.Date_end_DTP.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.Date_end_DTP.CustomFormat = "MMMM dd, yyyy";
            this.Date_end_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_end_DTP.Location = new System.Drawing.Point(631, 90);
            this.Date_end_DTP.Name = "Date_end_DTP";
            this.Date_end_DTP.Size = new System.Drawing.Size(180, 20);
            this.Date_end_DTP.TabIndex = 9;
            // 
            // Date_start_DTP
            // 
            this.Date_start_DTP.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.Date_start_DTP.CustomFormat = "MMMM dd, yyyy";
            this.Date_start_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_start_DTP.Location = new System.Drawing.Point(215, 89);
            this.Date_start_DTP.Name = "Date_start_DTP";
            this.Date_start_DTP.Size = new System.Drawing.Size(180, 20);
            this.Date_start_DTP.TabIndex = 9;
            // 
            // scope_uslug_TB
            // 
            this.scope_uslug_TB.Location = new System.Drawing.Point(674, 18);
            this.scope_uslug_TB.Name = "scope_uslug_TB";
            this.scope_uslug_TB.Size = new System.Drawing.Size(137, 20);
            this.scope_uslug_TB.TabIndex = 8;
            // 
            // vid_uslugi_CB
            // 
            this.vid_uslugi_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vid_uslugi_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vid_uslugi_CB.DataSource = this.видуслугиBindingSource;
            this.vid_uslugi_CB.DisplayMember = "Наименование_вида_услуги";
            this.vid_uslugi_CB.FormattingEnabled = true;
            this.vid_uslugi_CB.Location = new System.Drawing.Point(215, 18);
            this.vid_uslugi_CB.Name = "vid_uslugi_CB";
            this.vid_uslugi_CB.Size = new System.Drawing.Size(316, 21);
            this.vid_uslugi_CB.TabIndex = 7;
            // 
            // видуслугиBindingSource
            // 
            this.видуслугиBindingSource.DataMember = "Вид_услуги";
            this.видуслугиBindingSource.DataSource = this.dmitriichuk_kpDataSet3;
            // 
            // dmitriichuk_kpDataSet3
            // 
            this.dmitriichuk_kpDataSet3.DataSetName = "dmitriichuk_kpDataSet3";
            this.dmitriichuk_kpDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usluga_CB
            // 
            this.usluga_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.usluga_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.usluga_CB.DataSource = this.услугиBindingSource;
            this.usluga_CB.DisplayMember = "Наименование_услуги";
            this.usluga_CB.FormattingEnabled = true;
            this.usluga_CB.Location = new System.Drawing.Point(215, 55);
            this.usluga_CB.Name = "usluga_CB";
            this.usluga_CB.Size = new System.Drawing.Size(596, 21);
            this.usluga_CB.TabIndex = 6;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.dmitriichuk_kpDataSet12;
            // 
            // dmitriichuk_kpDataSet12
            // 
            this.dmitriichuk_kpDataSet12.DataSetName = "dmitriichuk_kpDataSet12";
            this.dmitriichuk_kpDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // type_uslugi_label
            // 
            this.type_uslugi_label.AutoSize = true;
            this.type_uslugi_label.Location = new System.Drawing.Point(147, 21);
            this.type_uslugi_label.Name = "type_uslugi_label";
            this.type_uslugi_label.Size = new System.Drawing.Size(62, 13);
            this.type_uslugi_label.TabIndex = 2;
            this.type_uslugi_label.Text = "Вид услуги";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(449, 93);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(176, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Дата окончания оказания услуги";
            // 
            // Date_start_label
            // 
            this.Date_start_label.AutoSize = true;
            this.Date_start_label.Location = new System.Drawing.Point(51, 92);
            this.Date_start_label.Name = "Date_start_label";
            this.Date_start_label.Size = new System.Drawing.Size(158, 13);
            this.Date_start_label.TabIndex = 2;
            this.Date_start_label.Text = "Дата начала оказания услуги";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(61, 126);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(148, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Итоговая стоимость услуги";
            // 
            // cost_service_label
            // 
            this.cost_service_label.AutoSize = true;
            this.cost_service_label.Location = new System.Drawing.Point(294, 125);
            this.cost_service_label.Name = "cost_service_label";
            this.cost_service_label.Size = new System.Drawing.Size(24, 13);
            this.cost_service_label.TabIndex = 2;
            this.cost_service_label.Text = "руб";
            // 
            // scope_services_label
            // 
            this.scope_services_label.AutoSize = true;
            this.scope_services_label.Location = new System.Drawing.Point(626, 21);
            this.scope_services_label.Name = "scope_services_label";
            this.scope_services_label.Size = new System.Drawing.Size(42, 13);
            this.scope_services_label.TabIndex = 2;
            this.scope_services_label.Text = "Объем";
            // 
            // name_uslugi_label
            // 
            this.name_uslugi_label.AutoSize = true;
            this.name_uslugi_label.Location = new System.Drawing.Point(90, 58);
            this.name_uslugi_label.Name = "name_uslugi_label";
            this.name_uslugi_label.Size = new System.Drawing.Size(119, 13);
            this.name_uslugi_label.TabIndex = 2;
            this.name_uslugi_label.Text = "Наименование услуги";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.client_contingent);
            this.groupBox4.Controls.Add(this.change_patient_button_minus);
            this.groupBox4.Controls.Add(this.patient_ex_address_TB);
            this.groupBox4.Controls.Add(this.change_patient_button_plus);
            this.groupBox4.Controls.Add(this.patient_ex_patronimyc_TB);
            this.groupBox4.Controls.Add(this.patient_ex_name_TB);
            this.groupBox4.Controls.Add(this.patient_address_text);
            this.groupBox4.Controls.Add(this.patient_ex_surname_TB);
            this.groupBox4.Controls.Add(this.patient_dob_text);
            this.groupBox4.Controls.Add(this.patient_contingent_text);
            this.groupBox4.Controls.Add(this.patient_patronimyc_text);
            this.groupBox4.Controls.Add(this.patient_name_text);
            this.groupBox4.Controls.Add(this.patient_surname_text);
            this.groupBox4.Controls.Add(this.patient_num_passport);
            this.groupBox4.Controls.Add(this.num_passport_ex_client_CB);
            this.groupBox4.Controls.Add(this.exist_client_RB);
            this.groupBox4.Controls.Add(this.new_client_RB);
            this.groupBox4.Controls.Add(this.UPD_skidka_button);
            this.groupBox4.Controls.Add(this.skidka_TB);
            this.groupBox4.Controls.Add(this.skidka_label);
            this.groupBox4.Controls.Add(this.client_phone_text);
            this.groupBox4.Controls.Add(this.add_client_button);
            this.groupBox4.Controls.Add(this.client_contingent_text);
            this.groupBox4.Controls.Add(this.client_patronymic_text);
            this.groupBox4.Controls.Add(this.client_phone);
            this.groupBox4.Controls.Add(this.client_address_text);
            this.groupBox4.Controls.Add(this.client_surname_text);
            this.groupBox4.Controls.Add(this.client_date_of_birth_text);
            this.groupBox4.Controls.Add(this.client_name_text);
            this.groupBox4.Controls.Add(this.client_num_passport_text);
            this.groupBox4.Controls.Add(this.client_patronymic);
            this.groupBox4.Controls.Add(this.client_series_passport_text);
            this.groupBox4.Controls.Add(this.client_surname);
            this.groupBox4.Controls.Add(this.client_name);
            this.groupBox4.Controls.Add(this.client_series_passport);
            this.groupBox4.Controls.Add(this.client_date_of_birth);
            this.groupBox4.Controls.Add(this.patient_ex_dob_TB);
            this.groupBox4.Controls.Add(this.client_address);
            this.groupBox4.Controls.Add(this.patient_ex_contingent_TB);
            this.groupBox4.Controls.Add(this.client_num_passport);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 312);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Данные клиента";
            // 
            // client_contingent
            // 
            this.client_contingent.FormattingEnabled = true;
            this.client_contingent.Items.AddRange(new object[] {
            "ДМС",
            "Ветеран ВОВ",
            "Инвалид 1 группы",
            "Инвалид 2 группы",
            "Инвалид 3 группы",
            "Пенсионер"});
            this.client_contingent.Location = new System.Drawing.Point(126, 281);
            this.client_contingent.Name = "client_contingent";
            this.client_contingent.Size = new System.Drawing.Size(174, 21);
            this.client_contingent.TabIndex = 32;
            // 
            // change_patient_button_minus
            // 
            this.change_patient_button_minus.Enabled = false;
            this.change_patient_button_minus.Location = new System.Drawing.Point(126, 253);
            this.change_patient_button_minus.Name = "change_patient_button_minus";
            this.change_patient_button_minus.Size = new System.Drawing.Size(22, 23);
            this.change_patient_button_minus.TabIndex = 19;
            this.change_patient_button_minus.Text = "<";
            this.change_patient_button_minus.UseVisualStyleBackColor = true;
            this.change_patient_button_minus.Visible = false;
            this.change_patient_button_minus.Click += new System.EventHandler(this.change_patient_button_minus_Click);
            // 
            // patient_ex_address_TB
            // 
            this.patient_ex_address_TB.Enabled = false;
            this.patient_ex_address_TB.Location = new System.Drawing.Point(126, 229);
            this.patient_ex_address_TB.Name = "patient_ex_address_TB";
            this.patient_ex_address_TB.ReadOnly = true;
            this.patient_ex_address_TB.Size = new System.Drawing.Size(174, 20);
            this.patient_ex_address_TB.TabIndex = 27;
            this.patient_ex_address_TB.Visible = false;
            // 
            // patient_ex_contingent_TB
            // 
            this.patient_ex_contingent_TB.Enabled = false;
            this.patient_ex_contingent_TB.Location = new System.Drawing.Point(126, 175);
            this.patient_ex_contingent_TB.Name = "patient_ex_contingent_TB";
            this.patient_ex_contingent_TB.ReadOnly = true;
            this.patient_ex_contingent_TB.Size = new System.Drawing.Size(174, 20);
            this.patient_ex_contingent_TB.TabIndex = 27;
            this.patient_ex_contingent_TB.Visible = false;
            // 
            // change_patient_button_plus
            // 
            this.change_patient_button_plus.Enabled = false;
            this.change_patient_button_plus.Location = new System.Drawing.Point(279, 253);
            this.change_patient_button_plus.Name = "change_patient_button_plus";
            this.change_patient_button_plus.Size = new System.Drawing.Size(21, 23);
            this.change_patient_button_plus.TabIndex = 19;
            this.change_patient_button_plus.Text = ">";
            this.change_patient_button_plus.UseVisualStyleBackColor = true;
            this.change_patient_button_plus.Visible = false;
            this.change_patient_button_plus.Click += new System.EventHandler(this.change_patient_button_plus_Click);
            // 
            // patient_ex_patronimyc_TB
            // 
            this.patient_ex_patronimyc_TB.Enabled = false;
            this.patient_ex_patronimyc_TB.Location = new System.Drawing.Point(126, 149);
            this.patient_ex_patronimyc_TB.Name = "patient_ex_patronimyc_TB";
            this.patient_ex_patronimyc_TB.ReadOnly = true;
            this.patient_ex_patronimyc_TB.Size = new System.Drawing.Size(174, 20);
            this.patient_ex_patronimyc_TB.TabIndex = 28;
            this.patient_ex_patronimyc_TB.Visible = false;
            // 
            // patient_ex_name_TB
            // 
            this.patient_ex_name_TB.Enabled = false;
            this.patient_ex_name_TB.Location = new System.Drawing.Point(126, 123);
            this.patient_ex_name_TB.Name = "patient_ex_name_TB";
            this.patient_ex_name_TB.ReadOnly = true;
            this.patient_ex_name_TB.Size = new System.Drawing.Size(174, 20);
            this.patient_ex_name_TB.TabIndex = 29;
            this.patient_ex_name_TB.Visible = false;
            // 
            // patient_address_text
            // 
            this.patient_address_text.AutoSize = true;
            this.patient_address_text.Enabled = false;
            this.patient_address_text.Location = new System.Drawing.Point(15, 232);
            this.patient_address_text.Name = "patient_address_text";
            this.patient_address_text.Size = new System.Drawing.Size(103, 13);
            this.patient_address_text.TabIndex = 22;
            this.patient_address_text.Text = "Адрес проживания";
            this.patient_address_text.Visible = false;
            // 
            // patient_ex_surname_TB
            // 
            this.patient_ex_surname_TB.Enabled = false;
            this.patient_ex_surname_TB.Location = new System.Drawing.Point(126, 97);
            this.patient_ex_surname_TB.Name = "patient_ex_surname_TB";
            this.patient_ex_surname_TB.ReadOnly = true;
            this.patient_ex_surname_TB.Size = new System.Drawing.Size(174, 20);
            this.patient_ex_surname_TB.TabIndex = 30;
            this.patient_ex_surname_TB.Visible = false;
            // 
            // patient_dob_text
            // 
            this.patient_dob_text.AutoSize = true;
            this.patient_dob_text.Enabled = false;
            this.patient_dob_text.Location = new System.Drawing.Point(34, 206);
            this.patient_dob_text.Name = "patient_dob_text";
            this.patient_dob_text.Size = new System.Drawing.Size(86, 13);
            this.patient_dob_text.TabIndex = 23;
            this.patient_dob_text.Text = "Дата рождения";
            this.patient_dob_text.Visible = false;
            // 
            // patient_contingent_text
            // 
            this.patient_contingent_text.AutoSize = true;
            this.patient_contingent_text.Enabled = false;
            this.patient_contingent_text.Location = new System.Drawing.Point(55, 178);
            this.patient_contingent_text.Name = "patient_contingent_text";
            this.patient_contingent_text.Size = new System.Drawing.Size(65, 13);
            this.patient_contingent_text.TabIndex = 22;
            this.patient_contingent_text.Text = "Контингент";
            this.patient_contingent_text.Visible = false;
            // 
            // patient_patronimyc_text
            // 
            this.patient_patronimyc_text.AutoSize = true;
            this.patient_patronimyc_text.Enabled = false;
            this.patient_patronimyc_text.Location = new System.Drawing.Point(66, 152);
            this.patient_patronimyc_text.Name = "patient_patronimyc_text";
            this.patient_patronimyc_text.Size = new System.Drawing.Size(54, 13);
            this.patient_patronimyc_text.TabIndex = 23;
            this.patient_patronimyc_text.Text = "Отчество";
            this.patient_patronimyc_text.Visible = false;
            // 
            // patient_name_text
            // 
            this.patient_name_text.AutoSize = true;
            this.patient_name_text.Enabled = false;
            this.patient_name_text.Location = new System.Drawing.Point(89, 126);
            this.patient_name_text.Name = "patient_name_text";
            this.patient_name_text.Size = new System.Drawing.Size(29, 13);
            this.patient_name_text.TabIndex = 24;
            this.patient_name_text.Text = "Имя";
            this.patient_name_text.Visible = false;
            // 
            // patient_surname_text
            // 
            this.patient_surname_text.AutoSize = true;
            this.patient_surname_text.Enabled = false;
            this.patient_surname_text.Location = new System.Drawing.Point(64, 100);
            this.patient_surname_text.Name = "patient_surname_text";
            this.patient_surname_text.Size = new System.Drawing.Size(56, 13);
            this.patient_surname_text.TabIndex = 25;
            this.patient_surname_text.Text = "Фамилия";
            this.patient_surname_text.Visible = false;
            // 
            // patient_num_passport
            // 
            this.patient_num_passport.AutoSize = true;
            this.patient_num_passport.Enabled = false;
            this.patient_num_passport.Location = new System.Drawing.Point(27, 75);
            this.patient_num_passport.Name = "patient_num_passport";
            this.patient_num_passport.Size = new System.Drawing.Size(91, 13);
            this.patient_num_passport.TabIndex = 26;
            this.patient_num_passport.Text = "Номер паспорта";
            this.patient_num_passport.Visible = false;
            // 
            // num_passport_ex_client_CB
            // 
            this.num_passport_ex_client_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.num_passport_ex_client_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.num_passport_ex_client_CB.DataSource = this.пациентыBindingSource;
            this.num_passport_ex_client_CB.DisplayMember = "Номер_паспорта";
            this.num_passport_ex_client_CB.Enabled = false;
            this.num_passport_ex_client_CB.FormattingEnabled = true;
            this.num_passport_ex_client_CB.Location = new System.Drawing.Point(126, 70);
            this.num_passport_ex_client_CB.Name = "num_passport_ex_client_CB";
            this.num_passport_ex_client_CB.Size = new System.Drawing.Size(174, 21);
            this.num_passport_ex_client_CB.TabIndex = 21;
            this.num_passport_ex_client_CB.Visible = false;
            this.num_passport_ex_client_CB.SelectedIndexChanged += new System.EventHandler(this.num_passport_ex_client_CB_SelectedIndexChanged);
            // 
            // пациентыBindingSource
            // 
            this.пациентыBindingSource.DataMember = "Пациенты";
            this.пациентыBindingSource.DataSource = this.dmitriichuk_kpDataSet2;
            // 
            // dmitriichuk_kpDataSet2
            // 
            this.dmitriichuk_kpDataSet2.DataSetName = "dmitriichuk_kpDataSet2";
            this.dmitriichuk_kpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exist_client_RB
            // 
            this.exist_client_RB.AutoSize = true;
            this.exist_client_RB.Location = new System.Drawing.Point(247, 19);
            this.exist_client_RB.Name = "exist_client_RB";
            this.exist_client_RB.Size = new System.Drawing.Size(147, 17);
            this.exist_client_RB.TabIndex = 20;
            this.exist_client_RB.Text = "Существующий пациент";
            this.exist_client_RB.UseVisualStyleBackColor = true;
            this.exist_client_RB.CheckedChanged += new System.EventHandler(this.exist_client_RB_CheckedChanged);
            // 
            // new_client_RB
            // 
            this.new_client_RB.AutoSize = true;
            this.new_client_RB.Checked = true;
            this.new_client_RB.Location = new System.Drawing.Point(30, 19);
            this.new_client_RB.Name = "new_client_RB";
            this.new_client_RB.Size = new System.Drawing.Size(103, 17);
            this.new_client_RB.TabIndex = 19;
            this.new_client_RB.TabStop = true;
            this.new_client_RB.Text = "Новый пациент";
            this.new_client_RB.UseVisualStyleBackColor = true;
            // 
            // UPD_skidka_button
            // 
            this.UPD_skidka_button.Location = new System.Drawing.Point(357, 100);
            this.UPD_skidka_button.Name = "UPD_skidka_button";
            this.UPD_skidka_button.Size = new System.Drawing.Size(125, 34);
            this.UPD_skidka_button.TabIndex = 18;
            this.UPD_skidka_button.Text = "Рассчитать скидку";
            this.UPD_skidka_button.UseVisualStyleBackColor = true;
            this.UPD_skidka_button.Click += new System.EventHandler(this.UPD_skidka_button_Click_1);
            // 
            // skidka_TB
            // 
            this.skidka_TB.BackColor = System.Drawing.SystemColors.Window;
            this.skidka_TB.Location = new System.Drawing.Point(418, 71);
            this.skidka_TB.Name = "skidka_TB";
            this.skidka_TB.ReadOnly = true;
            this.skidka_TB.Size = new System.Drawing.Size(64, 20);
            this.skidka_TB.TabIndex = 17;
            // 
            // skidka_label
            // 
            this.skidka_label.AutoSize = true;
            this.skidka_label.Location = new System.Drawing.Point(354, 74);
            this.skidka_label.Name = "skidka_label";
            this.skidka_label.Size = new System.Drawing.Size(58, 13);
            this.skidka_label.TabIndex = 16;
            this.skidka_label.Text = "Скидка(%)";
            // 
            // client_phone_text
            // 
            this.client_phone_text.AutoSize = true;
            this.client_phone_text.Location = new System.Drawing.Point(27, 258);
            this.client_phone_text.Name = "client_phone_text";
            this.client_phone_text.Size = new System.Drawing.Size(93, 13);
            this.client_phone_text.TabIndex = 1;
            this.client_phone_text.Text = "Номер телефона";
            // 
            // add_client_button
            // 
            this.add_client_button.Location = new System.Drawing.Point(357, 275);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(125, 27);
            this.add_client_button.TabIndex = 3;
            this.add_client_button.Text = "Добавить пациента";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_Click);
            // 
            // client_contingent_text
            // 
            this.client_contingent_text.AutoSize = true;
            this.client_contingent_text.Location = new System.Drawing.Point(53, 284);
            this.client_contingent_text.Name = "client_contingent_text";
            this.client_contingent_text.Size = new System.Drawing.Size(65, 13);
            this.client_contingent_text.TabIndex = 1;
            this.client_contingent_text.Text = "Контингент";
            // 
            // client_patronymic_text
            // 
            this.client_patronymic_text.AutoSize = true;
            this.client_patronymic_text.Location = new System.Drawing.Point(64, 126);
            this.client_patronymic_text.Name = "client_patronymic_text";
            this.client_patronymic_text.Size = new System.Drawing.Size(54, 13);
            this.client_patronymic_text.TabIndex = 1;
            this.client_patronymic_text.Text = "Отчество";
            // 
            // client_phone
            // 
            this.client_phone.Location = new System.Drawing.Point(126, 255);
            this.client_phone.Name = "client_phone";
            this.client_phone.Size = new System.Drawing.Size(174, 20);
            this.client_phone.TabIndex = 0;
            // 
            // client_address_text
            // 
            this.client_address_text.AutoSize = true;
            this.client_address_text.Location = new System.Drawing.Point(17, 206);
            this.client_address_text.Name = "client_address_text";
            this.client_address_text.Size = new System.Drawing.Size(103, 13);
            this.client_address_text.TabIndex = 1;
            this.client_address_text.Text = "Адрес проживания";
            // 
            // client_surname_text
            // 
            this.client_surname_text.AutoSize = true;
            this.client_surname_text.Location = new System.Drawing.Point(64, 100);
            this.client_surname_text.Name = "client_surname_text";
            this.client_surname_text.Size = new System.Drawing.Size(56, 13);
            this.client_surname_text.TabIndex = 1;
            this.client_surname_text.Text = "Фамилия";
            // 
            // client_date_of_birth_text
            // 
            this.client_date_of_birth_text.AutoSize = true;
            this.client_date_of_birth_text.Location = new System.Drawing.Point(32, 232);
            this.client_date_of_birth_text.Name = "client_date_of_birth_text";
            this.client_date_of_birth_text.Size = new System.Drawing.Size(86, 13);
            this.client_date_of_birth_text.TabIndex = 1;
            this.client_date_of_birth_text.Text = "Дата рождения";
            // 
            // client_name_text
            // 
            this.client_name_text.AutoSize = true;
            this.client_name_text.Location = new System.Drawing.Point(91, 74);
            this.client_name_text.Name = "client_name_text";
            this.client_name_text.Size = new System.Drawing.Size(29, 13);
            this.client_name_text.TabIndex = 1;
            this.client_name_text.Text = "Имя";
            // 
            // client_num_passport_text
            // 
            this.client_num_passport_text.AutoSize = true;
            this.client_num_passport_text.Location = new System.Drawing.Point(29, 180);
            this.client_num_passport_text.Name = "client_num_passport_text";
            this.client_num_passport_text.Size = new System.Drawing.Size(91, 13);
            this.client_num_passport_text.TabIndex = 1;
            this.client_num_passport_text.Text = "Номер паспорта";
            // 
            // client_patronymic
            // 
            this.client_patronymic.Location = new System.Drawing.Point(126, 123);
            this.client_patronymic.Name = "client_patronymic";
            this.client_patronymic.Size = new System.Drawing.Size(174, 20);
            this.client_patronymic.TabIndex = 0;
            // 
            // client_series_passport_text
            // 
            this.client_series_passport_text.AutoSize = true;
            this.client_series_passport_text.Location = new System.Drawing.Point(32, 154);
            this.client_series_passport_text.Name = "client_series_passport_text";
            this.client_series_passport_text.Size = new System.Drawing.Size(88, 13);
            this.client_series_passport_text.TabIndex = 1;
            this.client_series_passport_text.Text = "Серия паспорта";
            // 
            // client_surname
            // 
            this.client_surname.Location = new System.Drawing.Point(126, 97);
            this.client_surname.Name = "client_surname";
            this.client_surname.Size = new System.Drawing.Size(174, 20);
            this.client_surname.TabIndex = 0;
            // 
            // client_name
            // 
            this.client_name.Location = new System.Drawing.Point(126, 71);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(174, 20);
            this.client_name.TabIndex = 0;
            // 
            // client_num_passport
            // 
            this.client_num_passport.Location = new System.Drawing.Point(126, 177);
            this.client_num_passport.Name = "client_num_passport";
            this.client_num_passport.Size = new System.Drawing.Size(174, 20);
            this.client_num_passport.TabIndex = 0;
            // 
            // client_series_passport
            // 
            this.client_series_passport.Location = new System.Drawing.Point(126, 151);
            this.client_series_passport.Name = "client_series_passport";
            this.client_series_passport.Size = new System.Drawing.Size(174, 20);
            this.client_series_passport.TabIndex = 0;
            // 
            // client_date_of_birth
            // 
            this.client_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.client_date_of_birth.Location = new System.Drawing.Point(126, 229);
            this.client_date_of_birth.Name = "client_date_of_birth";
            this.client_date_of_birth.Size = new System.Drawing.Size(174, 20);
            this.client_date_of_birth.TabIndex = 33;
            // 
            // patient_ex_dob_TB
            // 
            this.patient_ex_dob_TB.Enabled = false;
            this.patient_ex_dob_TB.Location = new System.Drawing.Point(126, 203);
            this.patient_ex_dob_TB.MaxLength = 8;
            this.patient_ex_dob_TB.Name = "patient_ex_dob_TB";
            this.patient_ex_dob_TB.ReadOnly = true;
            this.patient_ex_dob_TB.Size = new System.Drawing.Size(174, 20);
            this.patient_ex_dob_TB.TabIndex = 28;
            this.patient_ex_dob_TB.Visible = false;
            // 
            // client_address
            // 
            this.client_address.Location = new System.Drawing.Point(126, 203);
            this.client_address.Name = "client_address";
            this.client_address.Size = new System.Drawing.Size(174, 20);
            this.client_address.TabIndex = 0;
            // 
            // Statistic
            // 
            this.Statistic.Controls.Add(this.chart1);
            this.Statistic.Controls.Add(this.button2);
            this.Statistic.Controls.Add(this.button1);
            this.Statistic.Location = new System.Drawing.Point(4, 22);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(1428, 626);
            this.Statistic.TabIndex = 2;
            this.Statistic.Text = "Статистика";
            this.Statistic.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-4, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Услуги";
            series3.YValuesPerPoint = 4;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1424, 490);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Оказано услуг на сумму (по месяцам)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Количество оказанных услуг по месяцам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // учетплатныхуслугBindingSource
            // 
            this.учетплатныхуслугBindingSource.DataMember = "Учет_платных_услуг";
            this.учетплатныхуслугBindingSource.DataSource = this.dmitriichuk_kpDataSet11;
            // 
            // dmitriichuk_kpDataSet11
            // 
            this.dmitriichuk_kpDataSet11.DataSetName = "dmitriichuk_kpDataSet11";
            this.dmitriichuk_kpDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // прейскурантповидууслугBindingSource
            // 
            this.прейскурантповидууслугBindingSource.DataMember = "Прейскурант_по_виду_услуг";
            this.прейскурантповидууслугBindingSource.DataSource = this.dmitriichuk_kpDataSet4;
            // 
            // dmitriichuk_kpDataSet4
            // 
            this.dmitriichuk_kpDataSet4.DataSetName = "dmitriichuk_kpDataSet4";
            this.dmitriichuk_kpDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsSurNameSerPNumPBindingSource
            // 
            this.patientsSurNameSerPNumPBindingSource.DataMember = "Patients_SurName_SerP_NumP";
            this.patientsSurNameSerPNumPBindingSource.DataSource = this.dmitriichuk_kpDataSet1;
            // 
            // dmitriichuk_kpDataSet1
            // 
            this.dmitriichuk_kpDataSet1.DataSetName = "dmitriichuk_kpDataSet1";
            this.dmitriichuk_kpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raschetskidkiBindingSource
            // 
            this.raschetskidkiBindingSource.DataMember = "Raschet_skidki";
            this.raschetskidkiBindingSource.DataSource = this.dmitriichuk_kpDataSet10;
            // 
            // dmitriichuk_kpDataSet10
            // 
            this.dmitriichuk_kpDataSet10.DataSetName = "dmitriichuk_kpDataSet10";
            this.dmitriichuk_kpDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statisticBindingSource
            // 
            this.statisticBindingSource.DataMember = "Statistic";
            this.statisticBindingSource.DataSource = this.dmitriichuk_kpDataSet9;
            // 
            // dmitriichuk_kpDataSet9
            // 
            this.dmitriichuk_kpDataSet9.DataSetName = "dmitriichuk_kpDataSet9";
            this.dmitriichuk_kpDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // patients_SurName_SerP_NumPTableAdapter
            // 
            this.patients_SurName_SerP_NumPTableAdapter.ClearBeforeFill = true;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // вид_услугиTableAdapter
            // 
            this.вид_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // прейскурант_по_виду_услугTableAdapter
            // 
            this.прейскурант_по_виду_услугTableAdapter.ClearBeforeFill = true;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // реестр_специализацийTableAdapter
            // 
            this.реестр_специализацийTableAdapter.ClearBeforeFill = true;
            // 
            // dmitriichuk_kpDataSet8
            // 
            this.dmitriichuk_kpDataSet8.DataSetName = "dmitriichuk_kpDataSet8";
            this.dmitriichuk_kpDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dmitriichukkpDataSet8BindingSource
            // 
            this.dmitriichukkpDataSet8BindingSource.DataSource = this.dmitriichuk_kpDataSet8;
            this.dmitriichukkpDataSet8BindingSource.Position = 0;
            // 
            // statisticTableAdapter
            // 
            this.statisticTableAdapter.ClearBeforeFill = true;
            // 
            // raschet_skidkiTableAdapter
            // 
            this.raschet_skidkiTableAdapter.ClearBeforeFill = true;
            // 
            // учет_платных_услугTableAdapter
            // 
            this.учет_платных_услугTableAdapter.ClearBeforeFill = true;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 652);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ИС учета платных медицинских услуг. Дмитрийчук Антон 4-МД-15";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.Contract_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Podchinennaya_forma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.реестрспециализацийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видуслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet12)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet2)).EndInit();
            this.Statistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетплатныхуслугBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прейскурантповидууслугBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsSurNameSerPNumPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raschetskidkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichuk_kpDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmitriichukkpDataSet8BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Contract_page;
        private System.Windows.Forms.Label client_phone_text;
        private System.Windows.Forms.Label client_address_text;
        private System.Windows.Forms.Label client_patronymic_text;
        private System.Windows.Forms.Label client_num_passport_text;
        private System.Windows.Forms.Label client_surname_text;
        private System.Windows.Forms.Label client_series_passport_text;
        private System.Windows.Forms.Label client_name_text;
        private System.Windows.Forms.TextBox client_phone;
        private System.Windows.Forms.TextBox client_address;
        private System.Windows.Forms.TextBox client_num_passport;
        private System.Windows.Forms.TextBox client_patronymic;
        private System.Windows.Forms.TextBox client_series_passport;
        private System.Windows.Forms.TextBox client_surname;
        private System.Windows.Forms.TextBox client_name;
        private System.Windows.Forms.Label client_date_of_birth_text;
        private System.Windows.Forms.Label client_contingent_text;
        private System.Windows.Forms.Button add_client_button;
        private dmitriichuk_kpDataSet dmitriichuk_kpDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private dmitriichuk_kpDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private dmitriichuk_kpDataSet1 dmitriichuk_kpDataSet1;
        private System.Windows.Forms.BindingSource patientsSurNameSerPNumPBindingSource;
        private dmitriichuk_kpDataSet1TableAdapters.Patients_SurName_SerP_NumPTableAdapter patients_SurName_SerP_NumPTableAdapter;
        private dmitriichuk_kpDataSet2 dmitriichuk_kpDataSet2;
        private System.Windows.Forms.BindingSource пациентыBindingSource;
        private dmitriichuk_kpDataSet2TableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private dmitriichuk_kpDataSet3 dmitriichuk_kpDataSet3;
        private System.Windows.Forms.BindingSource видуслугиBindingSource;
        private dmitriichuk_kpDataSet3TableAdapters.Вид_услугиTableAdapter вид_услугиTableAdapter;
        private System.Windows.Forms.BindingSource прейскурантповидууслугBindingSource;
        private dmitriichuk_kpDataSet4 dmitriichuk_kpDataSet4;
        private dmitriichuk_kpDataSet4TableAdapters.Прейскурант_по_виду_услугTableAdapter прейскурант_по_виду_услугTableAdapter;
        private dmitriichuk_kpDataSet5 dmitriichuk_kpDataSet5;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private dmitriichuk_kpDataSet5TableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private dmitriichuk_kpDataSet6 dmitriichuk_kpDataSet6;
        private System.Windows.Forms.BindingSource реестрспециализацийBindingSource;
        private dmitriichuk_kpDataSet6TableAdapters.Реестр_специализацийTableAdapter реестр_специализацийTableAdapter;
        private System.Windows.Forms.BindingSource dmitriichukkpDataSet8BindingSource;
        private dmitriichuk_kpDataSet8 dmitriichuk_kpDataSet8;
        private System.Windows.Forms.BindingSource statisticBindingSource;
        private dmitriichuk_kpDataSet9 dmitriichuk_kpDataSet9;
        private dmitriichuk_kpDataSet9TableAdapters.StatisticTableAdapter statisticTableAdapter;
        private dmitriichuk_kpDataSet10 dmitriichuk_kpDataSet10;
        private System.Windows.Forms.BindingSource raschetskidkiBindingSource;
        private dmitriichuk_kpDataSet10TableAdapters.Raschet_skidkiTableAdapter raschet_skidkiTableAdapter;
        private System.Windows.Forms.TabPage Statistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox4;
        private dmitriichuk_kpDataSet11 dmitriichuk_kpDataSet11;
        private System.Windows.Forms.BindingSource учетплатныхуслугBindingSource;
        private dmitriichuk_kpDataSet11TableAdapters.Учет_платных_услугTableAdapter учет_платных_услугTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private dmitriichuk_kpDataSet12 dmitriichuk_kpDataSet12;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private dmitriichuk_kpDataSet12TableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FinCostRes_button;
        private System.Windows.Forms.TextBox cost_TB;
        private System.Windows.Forms.DateTimePicker Date_start_DTP;
        private System.Windows.Forms.TextBox scope_uslug_TB;
        private System.Windows.Forms.ComboBox vid_uslugi_CB;
        private System.Windows.Forms.ComboBox usluga_CB;
        private System.Windows.Forms.Label type_uslugi_label;
        private System.Windows.Forms.Label Date_start_label;
        private System.Windows.Forms.Label cost_service_label;
        private System.Windows.Forms.Label scope_services_label;
        private System.Windows.Forms.Label name_uslugi_label;
        private System.Windows.Forms.TextBox skidka_TB;
        private System.Windows.Forms.Label skidka_label;
        private System.Windows.Forms.Button UPD_skidka_button;
        private System.Windows.Forms.DateTimePicker Date_end_DTP;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button add_in_contract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button change_patient_button_minus;
        private System.Windows.Forms.Button change_patient_button_plus;
        private System.Windows.Forms.ComboBox specialization_doc_CB;
        private System.Windows.Forms.Label specialization_doc_label;
        private System.Windows.Forms.ComboBox doc_position_CB;
        private System.Windows.Forms.Button UPD_doctor_button;
        private System.Windows.Forms.TextBox otchestvo_doctor_TB;
        private System.Windows.Forms.TextBox name_doctor_TB;
        private System.Windows.Forms.Label position_doc_label;
        private System.Windows.Forms.ComboBox SN_doctor_CB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label surname_doc_label;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView Podchinennaya_forma;
        private System.Windows.Forms.RadioButton exist_client_RB;
        private System.Windows.Forms.RadioButton new_client_RB;
        private System.Windows.Forms.TextBox patient_ex_contingent_TB;
        private System.Windows.Forms.TextBox patient_ex_patronimyc_TB;
        private System.Windows.Forms.TextBox patient_ex_name_TB;
        private System.Windows.Forms.TextBox patient_ex_surname_TB;
        private System.Windows.Forms.Label patient_contingent_text;
        private System.Windows.Forms.Label patient_patronimyc_text;
        private System.Windows.Forms.Label patient_name_text;
        private System.Windows.Forms.Label patient_surname_text;
        private System.Windows.Forms.Label patient_num_passport;
        private System.Windows.Forms.ComboBox num_passport_ex_client_CB;
        private System.Windows.Forms.ComboBox client_contingent;
        private System.Windows.Forms.DateTimePicker client_date_of_birth;
        private System.Windows.Forms.TextBox patient_ex_address_TB;
        private System.Windows.Forms.TextBox patient_ex_dob_TB;
        private System.Windows.Forms.Label patient_address_text;
        private System.Windows.Forms.Label patient_dob_text;
        private System.Windows.Forms.Button change_doctor_button_minus;
        private System.Windows.Forms.Button change_doctor_button_plus;
        private System.Windows.Forms.Button Create_contract_btn;
        private System.Windows.Forms.Button Create_akt_btn;
        private System.Windows.Forms.Button Create_smeta_btn;
        private System.Windows.Forms.Button UPD_podchinennaya_forma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

