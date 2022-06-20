
namespace CargoLiftingDevicesProject
{
  partial class CargoLiftingDevicesForm
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
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonChange = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.comboBoxDevices = new System.Windows.Forms.ComboBox();
      this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.carryingCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.liftingHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cargoLiftingDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cargoLiftingDeviceBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(165, 3);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(103, 27);
      this.buttonAdd.TabIndex = 0;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
      // 
      // buttonChange
      // 
      this.buttonChange.Location = new System.Drawing.Point(274, 3);
      this.buttonChange.Name = "buttonChange";
      this.buttonChange.Size = new System.Drawing.Size(114, 27);
      this.buttonChange.TabIndex = 1;
      this.buttonChange.Text = "Изменить";
      this.buttonChange.UseVisualStyleBackColor = true;
      this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(395, 3);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(114, 27);
      this.buttonDelete.TabIndex = 2;
      this.buttonDelete.Text = "Удалить";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.dataGridViewDevices, 3, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.797271F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.20273F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 513);
      this.tableLayoutPanel1.TabIndex = 9;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel2.ColumnCount = 5;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.86395F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.13605F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
      this.tableLayoutPanel2.Controls.Add(this.buttonGenerate, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.buttonChange, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.comboBoxDevices, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 1, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 33);
      this.tableLayoutPanel2.TabIndex = 11;
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(564, 3);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(247, 27);
      this.buttonGenerate.TabIndex = 12;
      this.buttonGenerate.Text = "Генерировать тестовые записи";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
      // 
      // comboBoxDevices
      // 
      this.comboBoxDevices.FormattingEnabled = true;
      this.comboBoxDevices.Location = new System.Drawing.Point(3, 3);
      this.comboBoxDevices.Name = "comboBoxDevices";
      this.comboBoxDevices.Size = new System.Drawing.Size(156, 24);
      this.comboBoxDevices.TabIndex = 10;
      // 
      // dataGridViewDevices
      // 
      this.dataGridViewDevices.AutoGenerateColumns = false;
      this.dataGridViewDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.carryingCapacityDataGridViewTextBoxColumn,
            this.liftingHeightDataGridViewTextBoxColumn});
      this.dataGridViewDevices.ContextMenuStrip = this.contextMenuStrip;
      this.dataGridViewDevices.DataSource = this.cargoLiftingDeviceBindingSource;
      this.dataGridViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewDevices.Location = new System.Drawing.Point(3, 42);
      this.dataGridViewDevices.Name = "dataGridViewDevices";
      this.dataGridViewDevices.RowHeadersWidth = 50;
      this.dataGridViewDevices.RowTemplate.Height = 24;
      this.dataGridViewDevices.Size = new System.Drawing.Size(836, 468);
      this.dataGridViewDevices.TabIndex = 12;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
      this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // carryingCapacityDataGridViewTextBoxColumn
      // 
      this.carryingCapacityDataGridViewTextBoxColumn.DataPropertyName = "CarryingCapacity";
      this.carryingCapacityDataGridViewTextBoxColumn.HeaderText = "Грузоподъемность";
      this.carryingCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.carryingCapacityDataGridViewTextBoxColumn.Name = "carryingCapacityDataGridViewTextBoxColumn";
      // 
      // liftingHeightDataGridViewTextBoxColumn
      // 
      this.liftingHeightDataGridViewTextBoxColumn.DataPropertyName = "LiftingHeight";
      this.liftingHeightDataGridViewTextBoxColumn.HeaderText = "Высота подъема";
      this.liftingHeightDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.liftingHeightDataGridViewTextBoxColumn.Name = "liftingHeightDataGridViewTextBoxColumn";
      // 
      // contextMenuStrip
      // 
      this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip.Name = "contextMenuStrip";
      this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
      // 
      // cargoLiftingDeviceBindingSource
      // 
      this.cargoLiftingDeviceBindingSource.DataSource = typeof(CargoLiftingDevices.CargoLiftingDevice);
      // 
      // CargoLiftingDevicesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
      this.ClientSize = new System.Drawing.Size(866, 537);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(884, 584);
      this.Name = "CargoLiftingDevicesForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Устройства для подъема грузов";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cargoLiftingDeviceBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonChange;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.ComboBox comboBoxDevices;
    private System.Windows.Forms.DataGridView dataGridViewDevices;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    private System.Windows.Forms.BindingSource cargoLiftingDeviceBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn carryingCapacityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn liftingHeightDataGridViewTextBoxColumn;
  }
}

