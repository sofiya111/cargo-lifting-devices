using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Домкрат
  /// </summary>
  public class Jack : CargoLiftingDevice
  {
    /// <summary>
    /// Высота подхвата
    /// </summary>
    private int _pickupHeight;
    /// <summary>
    /// Рабочий ход штока
    /// </summary>
    private int _workingStrokeRod;
    /// <summary>
    /// Высота подхвата
    /// </summary>
    public int PickupHeight
    {
      get
      {
        return _pickupHeight;
      }
      set
      {
        _pickupHeight = value;
      }
    }
    /// <summary>
    /// Рабочий ход штока
    /// </summary>
    public int WorkingStrokeRod
    {
      get
      {
        return _workingStrokeRod;
      }
      set
      {
        _workingStrokeRod = value;
      }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parName">Название устройства для подъема груза</param>
    /// <param name="parCarryingCapacity">Грузоподъемность</param>
    /// <param name="parLiftingHeight">Высота подъема</param>
    /// <param name="parPickupHeight">Высота подхвата</param>
    /// <param name="parWorkingStrokeRod">Рабочий ход штока</param>
    public Jack(string parName, int parCarryingCapacity, int parLiftingHeight, int parPickupHeight, int parWorkingStrokeRod) :
        base(parName, parCarryingCapacity, parLiftingHeight)
    {
      _pickupHeight = parPickupHeight;
      _workingStrokeRod = parWorkingStrokeRod;
    }
  }
}
