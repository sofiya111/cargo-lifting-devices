
namespace CargoLiftingDevicesProject
{
  partial class OverheadCraneForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelDriveType = new System.Windows.Forms.Label();
      this.comboBoxDriveType = new System.Windows.Forms.ComboBox();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonAction = new System.Windows.Forms.Button();
      this.labelCraneBoomLength = new System.Windows.Forms.Label();
      this.labelLiftingHeight = new System.Windows.Forms.Label();
      this.labelCarryingCapacity = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.labelName = new System.Windows.Forms.Label();
      this.numericUpDownCraneBoomLength = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLiftingHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownCarryingCapacity = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCraneBoomLength)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).BeginInit();
      this.SuspendLayout();
      // 
      // labelDriveType
      // 
      this.labelDriveType.AutoSize = true;
      this.labelDriveType.Location = new System.Drawing.Point(60, 213);
      this.labelDriveType.Name = "labelDriveType";
      this.labelDriveType.Size = new System.Drawing.Size(92, 17);
      this.labelDriveType.TabIndex = 53;
      this.labelDriveType.Text = "Вид привода";
      // 
      // comboBoxDriveType
      // 
      this.comboBoxDriveType.FormattingEnabled = true;
      this.comboBoxDriveType.Items.AddRange(new object[] {
            "электрический",
            "ручной"});
      this.comboBoxDriveType.Location = new System.Drawing.Point(208, 210);
      this.comboBoxDriveType.Name = "comboBoxDriveType";
      this.comboBoxDriveType.Size = new System.Drawing.Size(167, 24);
      this.comboBoxDriveType.TabIndex = 52;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(234, 306);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(116, 35);
      this.buttonCancel.TabIndex = 51;
      this.buttonCancel.Text = "Отмена";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonAction
      // 
      this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAction.Location = new System.Drawing.Point(80, 306);
      this.buttonAction.Name = "buttonAction";
      this.buttonAction.Size = new System.Drawing.Size(116, 35);
      this.buttonAction.TabIndex = 50;
      this.buttonAction.Text = "button";
      this.buttonAction.UseVisualStyleBackColor = true;
      this.buttonAction.Click += new System.EventHandler(this.ButtonAction_Click);
      // 
      // labelCraneBoomLength
      // 
      this.labelCraneBoomLength.AutoSize = true;
      this.labelCraneBoomLength.Location = new System.Drawing.Point(60, 173);
      this.labelCraneBoomLength.Name = "labelCraneBoomLength";
      this.labelCraneBoomLength.Size = new System.Drawing.Size(146, 17);
      this.labelCraneBoomLength.TabIndex = 48;
      this.labelCraneBoomLength.Text = "Длина стрелы крана";
      // 
      // labelLiftingHeight
      // 
      this.labelLiftingHeight.AutoSize = true;
      this.labelLiftingHeight.Location = new System.Drawing.Point(60, 135);
      this.labelLiftingHeight.Name = "labelLiftingHeight";
      this.labelLiftingHeight.Size = new System.Drawing.Size(119, 17);
      this.labelLiftingHeight.TabIndex = 46;
      this.labelLiftingHeight.Text = "Высота подъема";
      // 
      // labelCarryingCapacity
      // 
      this.labelCarryingCapacity.AutoSize = true;
      this.labelCarryingCapacity.Location = new System.Drawing.Point(60, 95);
      this.labelCarryingCapacity.Name = "labelCarryingCapacity";
      this.labelCarryingCapacity.Size = new System.Drawing.Size(133, 17);
      this.labelCarryingCapacity.TabIndex = 44;
      this.labelCarryingCapacity.Text = "Грузоподъемность";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(208, 56);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(167, 22);
      this.textBoxName.TabIndex = 43;
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(60, 56);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(72, 17);
      this.labelName.TabIndex = 42;
      this.labelName.Text = "Название";
      // 
      // numericUpDownCraneBoomLength
      // 
      this.numericUpDownCraneBoomLength.Location = new System.Drawing.Point(208, 171);
      this.numericUpDownCraneBoomLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCraneBoomLength.Name = "numericUpDownCraneBoomLength";
      this.numericUpDownCraneBoomLength.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCraneBoomLength.TabIndex = 56;
      // 
      // numericUpDownLiftingHeight
      // 
      this.numericUpDownLiftingHeight.Location = new System.Drawing.Point(208, 135);
      this.numericUpDownLiftingHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownLiftingHeight.Name = "numericUpDownLiftingHeight";
      this.numericUpDownLiftingHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownLiftingHeight.TabIndex = 55;
      // 
      // numericUpDownCarryingCapacity
      // 
      this.numericUpDownCarryingCapacity.Location = new System.Drawing.Point(208, 95);
      this.numericUpDownCarryingCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCarryingCapacity.Name = "numericUpDownCarryingCapacity";
      this.numericUpDownCarryingCapacity.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCarryingCapacity.TabIndex = 54;
      // 
      // OverheadCraneForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 397);
      this.Controls.Add(this.numericUpDownCraneBoomLength);
      this.Controls.Add(this.numericUpDownLiftingHeight);
      this.Controls.Add(this.numericUpDownCarryingCapacity);
      this.Controls.Add(this.labelDriveType);
      this.Controls.Add(this.comboBoxDriveType);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAction);
      this.Controls.Add(this.labelCraneBoomLength);
      this.Controls.Add(this.labelLiftingHeight);
      this.Controls.Add(this.labelCarryingCapacity);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.MaximumSize = new System.Drawing.Size(453, 444);
      this.MinimumSize = new System.Drawing.Size(453, 444);
      this.Name = "OverheadCraneForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "OverheadCraneForm";
      this.Load += new System.EventHandler(this.OverheadCraneForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCraneBoomLength)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelDriveType;
    private System.Windows.Forms.ComboBox comboBoxDriveType;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonAction;
    private System.Windows.Forms.Label labelCraneBoomLength;
    private System.Windows.Forms.Label labelLiftingHeight;
    private System.Windows.Forms.Label labelCarryingCapacity;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.NumericUpDown numericUpDownCraneBoomLength;
    private System.Windows.Forms.NumericUpDown numericUpDownLiftingHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownCarryingCapacity;
  }
}