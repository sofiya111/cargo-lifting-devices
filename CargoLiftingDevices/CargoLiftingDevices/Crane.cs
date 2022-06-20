using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Кран
  /// </summary>
  public class Crane : CargoLiftingDevice
  {
    /// <summary>
    /// Длина стрелы крана
    /// </summary>
    private int _craneBoomLength;
    /// <summary>
    /// Длина стрелы крана
    /// </summary>
    public int CraneBoomLength
    {
      get
      {
        return _craneBoomLength;
      }
      set
      {
        _craneBoomLength = value;
      }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parName">Название устройства для подъема груза</param>
    /// <param name="parCarryingCapacity">Грузоподъемность</param>
    /// <param name="parLiftingHeight">Высота подъема</param>
    /// <param name="parCraneBoomLength">Длина стрелы крана</param>
    public Crane(string parName, int parCarryingCapacity, int parLiftingHeight, int parCraneBoomLength) :
        base(parName, parCarryingCapacity, parLiftingHeight)
    {
      _craneBoomLength = parCraneBoomLength;
    }
  }
}
