
namespace CargoLiftingDevicesProject
{
  partial class RhombicJackForm
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
      this.comboBoxScrewDriveMethod = new System.Windows.Forms.ComboBox();
      this.labelTypeRotation = new System.Windows.Forms.Label();
      this.labelWorkingStrokeRod = new System.Windows.Forms.Label();
      this.labelPickupHeight = new System.Windows.Forms.Label();
      this.labelLiftingHeight = new System.Windows.Forms.Label();
      this.labelCarryingCapacity = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.labelName = new System.Windows.Forms.Label();
      this.numericUpDownWorkingStrokeRod = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownPickupHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLiftingHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownCarryingCapacity = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingStrokeRod)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickupHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(237, 349);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(116, 35);
      this.buttonCancel.TabIndex = 27;
      this.buttonCancel.Text = "Отмена";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonAction
      // 
      this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAction.Location = new System.Drawing.Point(90, 349);
      this.buttonAction.Name = "buttonAction";
      this.buttonAction.Size = new System.Drawing.Size(116, 35);
      this.buttonAction.TabIndex = 26;
      this.buttonAction.Text = "button";
      this.buttonAction.UseVisualStyleBackColor = true;
      this.buttonAction.Click += new System.EventHandler(this.ButtonAction_Click);
      // 
      // comboBoxScrewDriveMethod
      // 
      this.comboBoxScrewDriveMethod.FormattingEnabled = true;
      this.comboBoxScrewDriveMethod.Items.AddRange(new object[] {
            "ручной",
            "электрический",
            "гидравлический"});
      this.comboBoxScrewDriveMethod.Location = new System.Drawing.Point(236, 260);
      this.comboBoxScrewDriveMethod.Name = "comboBoxScrewDriveMethod";
      this.comboBoxScrewDriveMethod.Size = new System.Drawing.Size(167, 24);
      this.comboBoxScrewDriveMethod.TabIndex = 25;
      // 
      // labelTypeRotation
      // 
      this.labelTypeRotation.AutoSize = true;
      this.labelTypeRotation.Location = new System.Drawing.Point(73, 263);
      this.labelTypeRotation.Name = "labelTypeRotation";
      this.labelTypeRotation.Size = new System.Drawing.Size(157, 17);
      this.labelTypeRotation.TabIndex = 24;
      this.labelTypeRotation.Text = "Способ привода винта";
      // 
      // labelWorkingStrokeRod
      // 
      this.labelWorkingStrokeRod.AutoSize = true;
      this.labelWorkingStrokeRod.Location = new System.Drawing.Point(73, 220);
      this.labelWorkingStrokeRod.Name = "labelWorkingStrokeRod";
      this.labelWorkingStrokeRod.Size = new System.Drawing.Size(136, 17);
      this.labelWorkingStrokeRod.TabIndex = 22;
      this.labelWorkingStrokeRod.Text = "Рабочий ход штока";
      // 
      // labelPickupHeight
      // 
      this.labelPickupHeight.AutoSize = true;
      this.labelPickupHeight.Location = new System.Drawing.Point(73, 183);
      this.labelPickupHeight.Name = "labelPickupHeight";
      this.labelPickupHeight.Size = new System.Drawing.Size(121, 17);
      this.labelPickupHeight.TabIndex = 20;
      this.labelPickupHeight.Text = "Высота подхвата";
      // 
      // labelLiftingHeight
      // 
      this.labelLiftingHeight.AutoSize = true;
      this.labelLiftingHeight.Location = new System.Drawing.Point(73, 145);
      this.labelLiftingHeight.Name = "labelLiftingHeight";
      this.labelLiftingHeight.Size = new System.Drawing.Size(119, 17);
      this.labelLiftingHeight.TabIndex = 18;
      this.labelLiftingHeight.Text = "Высота подъема";
      // 
      // labelCarryingCapacity
      // 
      this.labelCarryingCapacity.AutoSize = true;
      this.labelCarryingCapacity.Location = new System.Drawing.Point(73, 105);
      this.labelCarryingCapacity.Name = "labelCarryingCapacity";
      this.labelCarryingCapacity.Size = new System.Drawing.Size(133, 17);
      this.labelCarryingCapacity.TabIndex = 16;
      this.labelCarryingCapacity.Text = "Грузоподъемность";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(236, 66);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(167, 22);
      this.textBoxName.TabIndex = 15;
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(73, 66);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(72, 17);
      this.labelName.TabIndex = 14;
      this.labelName.Text = "Название";
      // 
      // numericUpDownWorkingStrokeRod
      // 
      this.numericUpDownWorkingStrokeRod.Location = new System.Drawing.Point(237, 220);
      this.numericUpDownWorkingStrokeRod.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownWorkingStrokeRod.Name = "numericUpDownWorkingStrokeRod";
      this.numericUpDownWorkingStrokeRod.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownWorkingStrokeRod.TabIndex = 31;
      // 
      // numericUpDownPickupHeight
      // 
      this.numericUpDownPickupHeight.Location = new System.Drawing.Point(237, 183);
      this.numericUpDownPickupHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownPickupHeight.Name = "numericUpDownPickupHeight";
      this.numericUpDownPickupHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownPickupHeight.TabIndex = 30;
      // 
      // numericUpDownLiftingHeight
      // 
      this.numericUpDownLiftingHeight.Location = new System.Drawing.Point(237, 145);
      this.numericUpDownLiftingHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownLiftingHeight.Name = "numericUpDownLiftingHeight";
      this.numericUpDownLiftingHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownLiftingHeight.TabIndex = 29;
      // 
      // numericUpDownCarryingCapacity
      // 
      this.numericUpDownCarryingCapacity.Location = new System.Drawing.Point(237, 105);
      this.numericUpDownCarryingCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCarryingCapacity.Name = "numericUpDownCarryingCapacity";
      this.numericUpDownCarryingCapacity.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCarryingCapacity.TabIndex = 28;
      // 
      // RhombicJackForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(453, 450);
      this.Controls.Add(this.numericUpDownWorkingStrokeRod);
      this.Controls.Add(this.numericUpDownPickupHeight);
      this.Controls.Add(this.numericUpDownLiftingHeight);
      this.Controls.Add(this.numericUpDownCarryingCapacity);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAction);
      this.Controls.Add(this.comboBoxScrewDriveMethod);
      this.Controls.Add(this.labelTypeRotation);
      this.Controls.Add(this.labelWorkingStrokeRod);
      this.Controls.Add(this.labelPickupHeight);
      this.Controls.Add(this.labelLiftingHeight);
      this.Controls.Add(this.labelCarryingCapacity);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.MaximumSize = new System.Drawing.Size(471, 497);
      this.MinimumSize = new System.Drawing.Size(471, 497);
      this.Name = "RhombicJackForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RhombicJackForm";
      this.Load += new System.EventHandler(this.RhombicJackForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingStrokeRod)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickupHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonAction;
    private System.Windows.Forms.ComboBox comboBoxScrewDriveMethod;
    private System.Windows.Forms.Label labelTypeRotation;
    private System.Windows.Forms.Label labelWorkingStrokeRod;
    private System.Windows.Forms.Label labelPickupHeight;
    private System.Windows.Forms.Label labelLiftingHeight;
    private System.Windows.Forms.Label labelCarryingCapacity;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.NumericUpDown numericUpDownWorkingStrokeRod;
    private System.Windows.Forms.NumericUpDown numericUpDownPickupHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownLiftingHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownCarryingCapacity;
  }
}