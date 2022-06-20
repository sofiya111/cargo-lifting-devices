using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Устройство для подъема грузов
  /// </summary>
  public class CargoLiftingDevice
  {
    /// <summary>
    /// Название устройства для подъема груза
    /// </summary>
    private string _name;
    /// <summary>
    /// Грузоподъемность 
    /// </summary>
    private int _carryingCapacity;
    /// <summary>
    /// Высота подъема
    /// </summary>
    private int _liftingHeight;
    /// <summary>
    /// Название устройства для подъема груза
    /// </summary>
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }
    /// <summary>
    /// Грузоподъемность
    /// </summary>
    public int CarryingCapacity
    {
      get
      {
        return _carryingCapacity;
      }
      set
      {
        _carryingCapacity = value;
      }
    }
    /// <summary>
    /// Высота подъема
    /// </summary>
    public int LiftingHeight
    {
      get
      {
        return _liftingHeight;
      }
      set
      {
        _liftingHeight = value;
      }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parName">Название устройства для подъема груза</param>
    /// <param name="parCarryingCapacity">Грузоподъемность</param>
    /// <param name="parLiftingHeight">Высота подъема</param>
    public CargoLiftingDevice(string parName, int parCarryingCapacity, int parLiftingHeight)
    {
      _name = parName;
      _carryingCapacity = parCarryingCapacity;
      _liftingHeight = parLiftingHeight;
    }
  }
}
