using System;
using System.Windows.Forms;
using CargoLiftingDevices;

namespace CargoLiftingDevicesProject
{
  /// <summary>
  /// Jib crane form
  /// </summary>
  public partial class JibCraneForm : Form
  {
    /// <summary>
    /// Operating mode
    /// </summary>
    private CargoLiftingDevicesForm.OperatingMode _operatingMode;
    /// <summary>
    /// Jib crane
    /// </summary>
    public JibCrane _jibCrane { get; set; } = null;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parOperatingMode">operating mode</param>
    public JibCraneForm(CargoLiftingDevicesForm.OperatingMode parOperatingMode)
    {
      InitializeComponent();
      this._operatingMode = parOperatingMode;
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
        int carryingCapacity = Convert.ToInt32(numericUpDownCarryingCapacity.Value);
        int liftingHeight = Convert.ToInt32(numericUpDownLiftingHeight.Value);
        int craneBoomLength = Convert.ToInt32(numericUpDownCraneBoomLength.Value);
        string jibEquipmentSuspensionDesign = comboBoxJibEquipmentSuspensionDesign.Text;
        JibCrane jibCrane = new JibCrane(name, carryingCapacity, liftingHeight, craneBoomLength, jibEquipmentSuspensionDesign);
        this._jibCrane = jibCrane;
      }
    }
    /// <summary>
    /// Jib crane form load handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void JibCraneForm_Load(object sender, EventArgs e)
    {
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Add)
      {
        buttonAction.Text = CargoLiftingDevicesForm.ADD_MODE_BUTTON_NAME;
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Change)
      {
        buttonAction.Text = CargoLiftingDevicesForm.CHANGE_MODE_BUTTON_NAME;
        textBoxName.Text = _jibCrane.Name;
        numericUpDownCarryingCapacity.Value = _jibCrane.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _jibCrane.LiftingHeight;
        numericUpDownCraneBoomLength.Value = _jibCrane.CraneBoomLength;
        comboBoxJibEquipmentSuspensionDesign.Text = Convert.ToString(_jibCrane.JibEquipmentSuspensionDesign);
      }
      if (_operatingMode == CargoLiftingDevicesForm.OperatingMode.Delete)
      {
        buttonAction.Text = CargoLiftingDevicesForm.DELETE_MODE_BUTTON_NAME;
        textBoxName.Text = _jibCrane.Name;
        numericUpDownCarryingCapacity.Value = _jibCrane.CarryingCapacity;
        numericUpDownLiftingHeight.Value = _jibCrane.LiftingHeight;
        numericUpDownCraneBoomLength.Value = _jibCrane.CraneBoomLength;
        comboBoxJibEquipmentSuspensionDesign.Text = Convert.ToString(_jibCrane.JibEquipmentSuspensionDesign);
        textBoxName.Enabled = false;
        numericUpDownCarryingCapacity.Enabled = false;
        numericUpDownLiftingHeight.Enabled = false;
        numericUpDownCraneBoomLength.Enabled = false;
        comboBoxJibEquipmentSuspensionDesign.Enabled = false;
      }
    }
  }
}
