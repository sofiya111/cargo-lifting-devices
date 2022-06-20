using System;
using System.Windows.Forms;
using CargoLiftingDevices;

namespace CargoLiftingDevicesProject
{
  /// <summary>
  /// Cable crane form
  /// </summary>
  public partial class CableCraneForm : Form
  {
    /// <summary>
    /// Operating mode
    /// </summary>
    private CargoLiftingDevicesForm.OperatingMode _operatingMode;
    /// <summary>
    /// Cable crane
    /// </summary>
    public CableCrane _cableCrane { get; set; } = null;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parOperatingMode">operating mode</param>
    public CableCraneForm(CargoLiftingDevicesForm.OperatingMode parOperatingMode)
    {
      InitializeComponent();
      this._operatingMode = parOperatingMode;
    }
    /// <summary>
    /// Cable crane form load handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CableCraneForm_Load(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add)
      {
        buttonAction.Text = CargoLiftingDevicesForm.ADD_MODE_BUTTON_NAME;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        buttonAction.Text = CargoLiftingDevicesForm.CHANGE_MODE_BUTTON_NAME;
        textBoxName.Text = _cableCrane.Name;
        numericUpDownCarryingCapacity.Value = _cableCrane.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _cableCrane.LiftingHeight;
        numericUpDownCraneBoomLength.Value = _cableCrane.CraneBoomLength;
        numericUpDownSpanSize.Value = _cableCrane.SpanSize;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Delete)
      {
        buttonAction.Text = CargoLiftingDevicesForm.DELETE_MODE_BUTTON_NAME;
        textBoxName.Text = _cableCrane.Name;
        numericUpDownCarryingCapacity.Value = _cableCrane.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _cableCrane.LiftingHeight;
        numericUpDownCraneBoomLength.Value = _cableCrane.CraneBoomLength;
        numericUpDownSpanSize.Value = _cableCrane.SpanSize;
        textBoxName.Enabled = false;
        numericUpDownCarryingCapacity.Enabled = false;
        numericUpDownLiftingHeight.Enabled = false;
        numericUpDownCraneBoomLength.Enabled = false;
        numericUpDownSpanSize.Enabled = false;
      }
    }
    /// <summary>
    /// Button action click handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonAction_Click(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add || _operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        string name = textBoxName.Text;
        int carryingCapacity = Convert.ToInt32(numericUpDownCarryingCapacity.Text);
        int liftingHeight = Convert.ToInt32(numericUpDownLiftingHeight.Text);
        int craneBoomLength = Convert.ToInt32(numericUpDownCraneBoomLength.Text);
        int spanSize = Convert.ToInt32(numericUpDownSpanSize.Text);
        CableCrane cableCrane = new CableCrane(name, carryingCapacity, liftingHeight, craneBoomLength, spanSize);
        this._cableCrane = cableCrane;
      }
    }
  }
}
