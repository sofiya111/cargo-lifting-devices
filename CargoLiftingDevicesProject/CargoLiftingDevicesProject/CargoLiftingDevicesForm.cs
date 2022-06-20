using System;
using System.Windows.Forms;
using CargoLiftingDevices;

namespace CargoLiftingDevicesProject
{
  /// <summary>
  /// Cargo lifting device form
  /// </summary>
  public partial class CargoLiftingDevicesForm : Form
  {
    /// <summary>
    /// Operating mode enumeration 
    /// </summary>
    public enum OperatingMode
    {
      /// <summary>
      /// Add mode
      /// </summary>
      Add,
      /// <summary>
      /// Change mode
      /// </summary>
      Change,
      /// <summary>
      /// Delete mode
      /// </summary>
      Delete
    }
    /// <summary>
    /// Button name in add mode
    /// </summary>
    public const String ADD_MODE_BUTTON_NAME = "Добавить";
    /// <summary>
    /// Button name in change mode
    /// </summary>
    public const String CHANGE_MODE_BUTTON_NAME = "Изменить";
    /// <summary>
    /// Button name in delete mode
    /// </summary>
    public const String DELETE_MODE_BUTTON_NAME = "Удалить";
    /// <summary>
    /// Template for the form in add mode
    /// </summary>
    private const String ADD_MODE_TEMPLATE_FORM_NAME = "Добавление {0}";
    /// <summary>
    /// Template for the form in change mode
    /// </summary>
    private const String CHANGE_MODE_TEMPLATE_FORM_NAME = "Изменение {0}";
    /// <summary>
    /// Template for the form in delete mode
    /// </summary>
    private const String DELETE_MODE_TEMPLATE_FORM_NAME = "Удаление {0}";
    /// <summary>
    /// Name for the bottle jack form
    /// </summary>
    private const String BOTTLE_JACK_FORM_NAME = "бутылочного домкрата";
    /// <summary>
    /// Name for the rhombic jack form
    /// </summary>
    private const String RHOMBIC_JACK_FORM_NAME = "ромбического домкрата";
    /// <summary>
    /// Name for the lever screw jack form
    /// </summary>
    private const String LEVER_SCREW_JACK_FORM_NAME = "рычажно-винтового домкрата";
    /// <summary>
    /// Name for the cable crane form
    /// </summary>
    private const String CABLE_CRANE_FORM_NAME = "кабельного крана";
    /// <summary>
    /// Name for the jib crane form
    /// </summary>
    private const String JIB_CRANE_FORM_NAME = "стрелового домкрата";
    /// <summary>
    /// Name for the overhead crane form
    /// </summary>
    private const String OVERHEAD_CRANE_FORM_NAME = "мостового домкрата";
    /// <summary>
    /// Bottle jack name
    /// </summary>
    private const String BOTTLE_JACK_NAME = "Бутылочный домкрат";
    /// <summary>
    /// Rhombic jack name
    /// </summary>
    private const String RHOMBIC_JACK_NAME = "Ромбический домкрат";
    /// <summary>
    /// Lever screw jack name
    /// </summary>
    private const String LEVER_SCREW_JACK_NAME = "Рычажно - винтовой домкрат";
    /// <summary>
    /// Cabel crane name
    /// </summary>
    private const String CABEL_CRANE_NAME = "Кабельный кран";
    /// <summary>
    /// Jib crane name
    /// </summary>
    private const String JIB_CRANE_NAME = "Стреловой кран";
    /// <summary>
    /// Overhead crane name
    /// </summary>
    private const String OVERHEAD_CRANE_NAME = "Мостовой кран";

    /// <summary>
    /// Constructor
    /// </summary>
    public CargoLiftingDevicesForm()
    {
      InitializeComponent();
      comboBoxDevices.Items.Add(BOTTLE_JACK_NAME);
      comboBoxDevices.SelectedIndex = 0;
      comboBoxDevices.Items.Add(RHOMBIC_JACK_NAME);
      comboBoxDevices.Items.Add(LEVER_SCREW_JACK_NAME);
      comboBoxDevices.Items.Add(CABEL_CRANE_NAME);
      comboBoxDevices.Items.Add(JIB_CRANE_NAME);
      comboBoxDevices.Items.Add(OVERHEAD_CRANE_NAME);

    }
    /// <summary>
    /// Add new device
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonAdd_Click(object sender, EventArgs e)
    {
      int selectedDevice = comboBoxDevices.SelectedIndex;
      DialogResult dialogResult;
      String title; 
      switch (selectedDevice)
      {
        case 0:
          BottleJackForm bottleJackForm = new BottleJackForm(OperatingMode.Add);
          title = String.Format(ADD_MODE_TEMPLATE_FORM_NAME, BOTTLE_JACK_FORM_NAME);
          bottleJackForm.Text = title;
          dialogResult = bottleJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.Add(bottleJackForm._bottleJack);
          }
          break;
        case 1:
          RhombicJackForm rhombicJackForm = new RhombicJackForm(OperatingMode.Add);
          title = String.Format(ADD_MODE_TEMPLATE_FORM_NAME, RHOMBIC_JACK_FORM_NAME);
          rhombicJackForm.Text = title;
          dialogResult = rhombicJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.Add(rhombicJackForm._rhombicJack);
          }
          break;
        case 2:
          LeverScrewJackForm leverScrewJackForm = new LeverScrewJackForm(OperatingMode.Add);
          title = String.Format(ADD_MODE_TEMPLATE_FORM_NAME, LEVER_SCREW_JACK_FORM_NAME);
          leverScrewJackForm.Text = title;
          dialogResult = leverScrewJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.Add(leverScrewJackForm._leverScrewJack);
          }
          break;
        case 3:
          CableCraneForm cableCraneForm = new CableCraneForm(OperatingMode.Add);
          title = String.Format(ADD_MODE_TEMPLATE_FORM_NAME, CABLE_CRANE_FORM_NAME);
          cableCraneForm.Text = title;
          dialogResult = cableCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.Add(cableCraneForm._cableCrane);
          }
          break;
        case 4:
          JibCraneForm jibCraneForm = new JibCraneForm(OperatingMode.Add);
          title = String.Format(ADD_MODE_TEMPLATE_FORM_NAME, JIB_CRANE_FORM_NAME);
          jibCraneForm.Text = title;
          dialogResult = jibCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.Add(jibCraneForm._jibCrane);
          }
          break;
        case 5:
          OverheadCraneForm overheadCraneForm = new OverheadCraneForm(OperatingMode.Add);
          title = String.Format(ADD_MODE_TEMPLATE_FORM_NAME, OVERHEAD_CRANE_FORM_NAME);
          overheadCraneForm.Text = title;
          dialogResult = overheadCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.Add(overheadCraneForm._overheadCrane);
          }
          break;
        default:
          break;
      }
    }
    /// <summary>
    /// Change selected device
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonChange_Click(object sender, EventArgs e)
    {
      int row = dataGridViewDevices.SelectedCells[0].RowIndex;
      String title;
      if(dataGridViewDevices.SelectedRows != null)
      {
        CargoLiftingDevice device = (CargoLiftingDevice) cargoLiftingDeviceBindingSource[row];
        DialogResult dialogResult;
        if (device is BottleJack)
        {
          BottleJackForm bottleJackForm = new BottleJackForm(OperatingMode.Change);
          title = String.Format(CHANGE_MODE_TEMPLATE_FORM_NAME, BOTTLE_JACK_FORM_NAME);
          bottleJackForm.Text = title;
          bottleJackForm._bottleJack = (BottleJack)device;
          dialogResult = bottleJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource[row] = bottleJackForm._bottleJack;
          }
        }
        if (device is RhombicJack)
        {
          RhombicJackForm rhombicJackForm = new RhombicJackForm(OperatingMode.Change);
          title = String.Format(CHANGE_MODE_TEMPLATE_FORM_NAME, RHOMBIC_JACK_FORM_NAME);
          rhombicJackForm.Text = title;
          rhombicJackForm._rhombicJack = (RhombicJack)device;
          dialogResult = rhombicJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource[row] = rhombicJackForm._rhombicJack;
          }
        }
        if (device is LeverScrewJack)
        {
          LeverScrewJackForm leverScrewJackForm = new LeverScrewJackForm(OperatingMode.Change);
          title = String.Format(CHANGE_MODE_TEMPLATE_FORM_NAME, LEVER_SCREW_JACK_FORM_NAME);
          leverScrewJackForm.Text = title;
          leverScrewJackForm._leverScrewJack = (LeverScrewJack)device;
          dialogResult = leverScrewJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource[row] = leverScrewJackForm._leverScrewJack;
          }
        }
        if (device is CableCrane)
        {
          CableCraneForm cableCraneForm = new CableCraneForm(OperatingMode.Change);
          title = String.Format(CHANGE_MODE_TEMPLATE_FORM_NAME, CABLE_CRANE_FORM_NAME);
          cableCraneForm.Text = title;
          cableCraneForm._cableCrane = (CableCrane)device;
          dialogResult = cableCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource[row] = cableCraneForm._cableCrane;
          }
        }
        if (device is JibCrane)
        {
          JibCraneForm jibCraneForm = new JibCraneForm(OperatingMode.Change);
          title = String.Format(CHANGE_MODE_TEMPLATE_FORM_NAME, JIB_CRANE_FORM_NAME);
          jibCraneForm.Text = title;
          jibCraneForm._jibCrane = (JibCrane)device;
          dialogResult = jibCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource[row] = jibCraneForm._jibCrane;
          }
        }
        if (device is OverheadCrane)
        {
          OverheadCraneForm overheadCraneForm = new OverheadCraneForm(OperatingMode.Change);
          title = String.Format(CHANGE_MODE_TEMPLATE_FORM_NAME, OVERHEAD_CRANE_FORM_NAME);
          overheadCraneForm.Text = title;
          overheadCraneForm._overheadCrane = (OverheadCrane)device;
          dialogResult = overheadCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource[row] = overheadCraneForm._overheadCrane;
          }
        }
      }
    }
    /// <summary>
    /// Delete selected device
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      int row = dataGridViewDevices.SelectedCells[0].RowIndex;
      String title;
      if (dataGridViewDevices.SelectedRows != null)
      {
        CargoLiftingDevice device = (CargoLiftingDevice)cargoLiftingDeviceBindingSource[row];
        DialogResult dialogResult;
        if (device is BottleJack)
        {
          BottleJackForm bottleJackForm = new BottleJackForm(OperatingMode.Delete);
          title = String.Format(DELETE_MODE_TEMPLATE_FORM_NAME, BOTTLE_JACK_FORM_NAME);
          bottleJackForm.Text = title;
          bottleJackForm._bottleJack = (BottleJack)device;
          dialogResult = bottleJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.RemoveAt(row);
          }
        }
        if (device is RhombicJack)
        {
          RhombicJackForm rhombicJackForm = new RhombicJackForm(OperatingMode.Delete);
          title = String.Format(DELETE_MODE_TEMPLATE_FORM_NAME, RHOMBIC_JACK_FORM_NAME);
          rhombicJackForm.Text = title;
          rhombicJackForm._rhombicJack = (RhombicJack)device;
          dialogResult = rhombicJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.RemoveAt(row);
          }
        }
        if (device is LeverScrewJack)
        {
          LeverScrewJackForm leverScrewJackForm = new LeverScrewJackForm(OperatingMode.Delete);
          title = String.Format(DELETE_MODE_TEMPLATE_FORM_NAME, LEVER_SCREW_JACK_FORM_NAME);
          leverScrewJackForm.Text = title;
          leverScrewJackForm._leverScrewJack = (LeverScrewJack)device;
          dialogResult = leverScrewJackForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.RemoveAt(row);
          }
        }
        if (device is CableCrane)
        {
          CableCraneForm cableCraneForm = new CableCraneForm(OperatingMode.Delete);
          title = String.Format(DELETE_MODE_TEMPLATE_FORM_NAME, CABLE_CRANE_FORM_NAME);
          cableCraneForm.Text = title;
          cableCraneForm._cableCrane = (CableCrane)device;
          dialogResult = cableCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.RemoveAt(row);
          }
        }
        if (device is JibCrane)
        {
          JibCraneForm jibCraneForm = new JibCraneForm(OperatingMode.Delete);
          title = String.Format(DELETE_MODE_TEMPLATE_FORM_NAME, JIB_CRANE_FORM_NAME);
          jibCraneForm.Text = title;
          jibCraneForm._jibCrane = (JibCrane)device;
          dialogResult = jibCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.RemoveAt(row);
          }
        }
        if (device is OverheadCrane)
        {
          OverheadCraneForm overheadCraneForm = new OverheadCraneForm(OperatingMode.Delete);
          title = String.Format(DELETE_MODE_TEMPLATE_FORM_NAME, OVERHEAD_CRANE_FORM_NAME);
          overheadCraneForm.Text = title;
          overheadCraneForm._overheadCrane = (OverheadCrane)device;
          dialogResult = overheadCraneForm.ShowDialog();
          if (dialogResult == DialogResult.OK)
          {
            cargoLiftingDeviceBindingSource.RemoveAt(row);
          }
        }
      }
      
    }
    /// <summary>
    /// Generate test data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
      for(int i=0; i < 1; i++)
      {
        cargoLiftingDeviceBindingSource.Add(new BottleJack("bottle jack 1", 50, 1, 2, 5, "по часовой стрелке"));
        cargoLiftingDeviceBindingSource.Add(new RhombicJack("rhombic jack 1", 60, 2, 3, 4, "ручной"));
        cargoLiftingDeviceBindingSource.Add(new LeverScrewJack("lever screw jack 1", 55, 1, 2, 5, 2));
        cargoLiftingDeviceBindingSource.Add(new CableCrane("cable crane 1", 1000, 50, 30, 15));
        cargoLiftingDeviceBindingSource.Add(new JibCrane("jib crane 1", 15000, 120, 30, "гибкая"));
        cargoLiftingDeviceBindingSource.Add(new OverheadCrane("overhead crane 1", 10000, 100, 70, "электрический"));
      }
    }
  }
}
