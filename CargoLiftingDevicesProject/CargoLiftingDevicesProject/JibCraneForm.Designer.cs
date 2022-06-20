
namespace CargoLiftingDevicesProject
{
  partial class JibCraneForm
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
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonAction = new System.Windows.Forms.Button();
      this.labelCraneBoomLength = new System.Windows.Forms.Label();
      this.labelLiftingHeight = new System.Windows.Forms.Label();
      this.labelCarryingCapacity = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.labelName = new System.Windows.Forms.Label();
      this.comboBoxJibEquipmentSuspensionDesign = new System.Windows.Forms.ComboBox();
      this.labelJibEquipmentSuspensionDesign = new System.Windows.Forms.Label();
      this.numericUpDownCarryingCapacity = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLiftingHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownCraneBoomLength = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCraneBoomLength)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(235, 310);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(116, 35);
      this.buttonCancel.TabIndex = 39;
      this.buttonCancel.Text = "Отмена";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonAction
      // 
      this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAction.Location = new System.Drawing.Point(81, 310);
      this.buttonAction.Name = "buttonAction";
      this.buttonAction.Size = new System.Drawing.Size(116, 35);
      this.buttonAction.TabIndex = 38;
      this.buttonAction.Text = "button";
      this.buttonAction.UseVisualStyleBackColor = true;
      this.buttonAction.Click += new System.EventHandler(this.ButtonAction_Click);
      // 
      // labelCraneBoomLength
      // 
      this.labelCraneBoomLength.AutoSize = true;
      this.labelCraneBoomLength.Location = new System.Drawing.Point(61, 177);
      this.labelCraneBoomLength.Name = "labelCraneBoomLength";
      this.labelCraneBoomLength.Size = new System.Drawing.Size(146, 17);
      this.labelCraneBoomLength.TabIndex = 34;
      this.labelCraneBoomLength.Text = "Длина стрелы крана";
      // 
      // labelLiftingHeight
      // 
      this.labelLiftingHeight.AutoSize = true;
      this.labelLiftingHeight.Location = new System.Drawing.Point(61, 139);
      this.labelLiftingHeight.Name = "labelLiftingHeight";
      this.labelLiftingHeight.Size = new System.Drawing.Size(119, 17);
      this.labelLiftingHeight.TabIndex = 32;
      this.labelLiftingHeight.Text = "Высота подъема";
      // 
      // labelCarryingCapacity
      // 
      this.labelCarryingCapacity.AutoSize = true;
      this.labelCarryingCapacity.Location = new System.Drawing.Point(61, 99);
      this.labelCarryingCapacity.Name = "labelCarryingCapacity";
      this.labelCarryingCapacity.Size = new System.Drawing.Size(133, 17);
      this.labelCarryingCapacity.TabIndex = 30;
      this.labelCarryingCapacity.Text = "Грузоподъемность";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(209, 60);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(167, 22);
      this.textBoxName.TabIndex = 29;
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(61, 60);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(72, 17);
      this.labelName.TabIndex = 28;
      this.labelName.Text = "Название";
      // 
      // comboBoxJibEquipmentSuspensionDesign
      // 
      this.comboBoxJibEquipmentSuspensionDesign.FormattingEnabled = true;
      this.comboBoxJibEquipmentSuspensionDesign.Items.AddRange(new object[] {
            "гибкая",
            "жесткая"});
      this.comboBoxJibEquipmentSuspensionDesign.Location = new System.Drawing.Point(209, 214);
      this.comboBoxJibEquipmentSuspensionDesign.Name = "comboBoxJibEquipmentSuspensionDesign";
      this.comboBoxJibEquipmentSuspensionDesign.Size = new System.Drawing.Size(167, 24);
      this.comboBoxJibEquipmentSuspensionDesign.TabIndex = 40;
      // 
      // labelJibEquipmentSuspensionDesign
      // 
      this.labelJibEquipmentSuspensionDesign.Location = new System.Drawing.Point(61, 217);
      this.labelJibEquipmentSuspensionDesign.Name = "labelJibEquipmentSuspensionDesign";
      this.labelJibEquipmentSuspensionDesign.Size = new System.Drawing.Size(133, 80);
      this.labelJibEquipmentSuspensionDesign.TabIndex = 41;
      this.labelJibEquipmentSuspensionDesign.Text = "Исполнение подвески стрелового оборудования";
      // 
      // numericUpDownCarryingCapacity
      // 
      this.numericUpDownCarryingCapacity.Location = new System.Drawing.Point(209, 99);
      this.numericUpDownCarryingCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCarryingCapacity.Name = "numericUpDownCarryingCapacity";
      this.numericUpDownCarryingCapacity.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCarryingCapacity.TabIndex = 42;
      // 
      // numericUpDownLiftingHeight
      // 
      this.numericUpDownLiftingHeight.Location = new System.Drawing.Point(209, 139);
      this.numericUpDownLiftingHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownLiftingHeight.Name = "numericUpDownLiftingHeight";
      this.numericUpDownLiftingHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownLiftingHeight.TabIndex = 43;
      // 
      // numericUpDownCraneBoomLength
      // 
      this.numericUpDownCraneBoomLength.Location = new System.Drawing.Point(209, 175);
      this.numericUpDownCraneBoomLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCraneBoomLength.Name = "numericUpDownCraneBoomLength";
      this.numericUpDownCraneBoomLength.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCraneBoomLength.TabIndex = 44;
      // 
      // JibCraneForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(441, 392);
      this.Controls.Add(this.numericUpDownCraneBoomLength);
      this.Controls.Add(this.numericUpDownLiftingHeight);
      this.Controls.Add(this.numericUpDownCarryingCapacity);
      this.Controls.Add(this.labelJibEquipmentSuspensionDesign);
      this.Controls.Add(this.comboBoxJibEquipmentSuspensionDesign);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAction);
      this.Controls.Add(this.labelCraneBoomLength);
      this.Controls.Add(this.labelLiftingHeight);
      this.Controls.Add(this.labelCarryingCapacity);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.MaximumSize = new System.Drawing.Size(459, 439);
      this.MinimumSize = new System.Drawing.Size(459, 439);
      this.Name = "JibCraneForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "JibCraneForm";
      this.Load += new System.EventHandler(this.JibCraneForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCraneBoomLength)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonAction;
    private System.Windows.Forms.Label labelCraneBoomLength;
    private System.Windows.Forms.Label labelLiftingHeight;
    private System.Windows.Forms.Label labelCarryingCapacity;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.ComboBox comboBoxJibEquipmentSuspensionDesign;
    private System.Windows.Forms.Label labelJibEquipmentSuspensionDesign;
    private System.Windows.Forms.NumericUpDown numericUpDownCarryingCapacity;
    private System.Windows.Forms.NumericUpDown numericUpDownLiftingHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownCraneBoomLength;
  }
}