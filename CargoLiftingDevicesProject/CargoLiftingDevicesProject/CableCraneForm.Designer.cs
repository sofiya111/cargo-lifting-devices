
namespace CargoLiftingDevicesProject
{
  partial class CableCraneForm
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
      this.labelSpanSize = new System.Windows.Forms.Label();
      this.numericUpDownCarryingCapacity = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownLiftingHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownCraneBoomLength = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownSpanSize = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCraneBoomLength)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpanSize)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(241, 321);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(116, 35);
      this.buttonCancel.TabIndex = 27;
      this.buttonCancel.Text = "Отмена";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonAction
      // 
      this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAction.Location = new System.Drawing.Point(92, 321);
      this.buttonAction.Name = "buttonAction";
      this.buttonAction.Size = new System.Drawing.Size(116, 35);
      this.buttonAction.TabIndex = 26;
      this.buttonAction.Text = "button";
      this.buttonAction.UseVisualStyleBackColor = true;
      this.buttonAction.Click += new System.EventHandler(this.ButtonAction_Click);
      // 
      // labelCraneBoomLength
      // 
      this.labelCraneBoomLength.AutoSize = true;
      this.labelCraneBoomLength.Location = new System.Drawing.Point(75, 183);
      this.labelCraneBoomLength.Name = "labelCraneBoomLength";
      this.labelCraneBoomLength.Size = new System.Drawing.Size(146, 17);
      this.labelCraneBoomLength.TabIndex = 20;
      this.labelCraneBoomLength.Text = "Длина стрелы крана";
      // 
      // labelLiftingHeight
      // 
      this.labelLiftingHeight.AutoSize = true;
      this.labelLiftingHeight.Location = new System.Drawing.Point(75, 145);
      this.labelLiftingHeight.Name = "labelLiftingHeight";
      this.labelLiftingHeight.Size = new System.Drawing.Size(119, 17);
      this.labelLiftingHeight.TabIndex = 18;
      this.labelLiftingHeight.Text = "Высота подъема";
      // 
      // labelCarryingCapacity
      // 
      this.labelCarryingCapacity.AutoSize = true;
      this.labelCarryingCapacity.Location = new System.Drawing.Point(75, 105);
      this.labelCarryingCapacity.Name = "labelCarryingCapacity";
      this.labelCarryingCapacity.Size = new System.Drawing.Size(133, 17);
      this.labelCarryingCapacity.TabIndex = 16;
      this.labelCarryingCapacity.Text = "Грузоподъемность";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(223, 66);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(167, 22);
      this.textBoxName.TabIndex = 15;
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(75, 66);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(72, 17);
      this.labelName.TabIndex = 14;
      this.labelName.Text = "Название";
      // 
      // labelSpanSize
      // 
      this.labelSpanSize.AutoSize = true;
      this.labelSpanSize.Location = new System.Drawing.Point(75, 223);
      this.labelSpanSize.Name = "labelSpanSize";
      this.labelSpanSize.Size = new System.Drawing.Size(116, 17);
      this.labelSpanSize.TabIndex = 37;
      this.labelSpanSize.Text = "Размер пролета";
      // 
      // numericUpDownCarryingCapacity
      // 
      this.numericUpDownCarryingCapacity.Location = new System.Drawing.Point(223, 105);
      this.numericUpDownCarryingCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCarryingCapacity.Name = "numericUpDownCarryingCapacity";
      this.numericUpDownCarryingCapacity.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCarryingCapacity.TabIndex = 38;
      // 
      // numericUpDownLiftingHeight
      // 
      this.numericUpDownLiftingHeight.Location = new System.Drawing.Point(223, 145);
      this.numericUpDownLiftingHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownLiftingHeight.Name = "numericUpDownLiftingHeight";
      this.numericUpDownLiftingHeight.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownLiftingHeight.TabIndex = 39;
      // 
      // numericUpDownCraneBoomLength
      // 
      this.numericUpDownCraneBoomLength.Location = new System.Drawing.Point(223, 183);
      this.numericUpDownCraneBoomLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownCraneBoomLength.Name = "numericUpDownCraneBoomLength";
      this.numericUpDownCraneBoomLength.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownCraneBoomLength.TabIndex = 40;
      // 
      // numericUpDownSpanSize
      // 
      this.numericUpDownSpanSize.Location = new System.Drawing.Point(223, 221);
      this.numericUpDownSpanSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numericUpDownSpanSize.Name = "numericUpDownSpanSize";
      this.numericUpDownSpanSize.Size = new System.Drawing.Size(61, 22);
      this.numericUpDownSpanSize.TabIndex = 41;
      // 
      // CableCraneForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(457, 390);
      this.Controls.Add(this.numericUpDownSpanSize);
      this.Controls.Add(this.numericUpDownCraneBoomLength);
      this.Controls.Add(this.numericUpDownLiftingHeight);
      this.Controls.Add(this.numericUpDownCarryingCapacity);
      this.Controls.Add(this.labelSpanSize);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAction);
      this.Controls.Add(this.labelCraneBoomLength);
      this.Controls.Add(this.labelLiftingHeight);
      this.Controls.Add(this.labelCarryingCapacity);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.MaximumSize = new System.Drawing.Size(475, 437);
      this.MinimumSize = new System.Drawing.Size(475, 437);
      this.Name = "CableCraneForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "CableCraneForm";
      this.Load += new System.EventHandler(this.CableCraneForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarryingCapacity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiftingHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCraneBoomLength)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpanSize)).EndInit();
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
    private System.Windows.Forms.Label labelSpanSize;
    private System.Windows.Forms.NumericUpDown numericUpDownCarryingCapacity;
    private System.Windows.Forms.NumericUpDown numericUpDownLiftingHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownCraneBoomLength;
    private System.Windows.Forms.NumericUpDown numericUpDownSpanSize;
  }
}