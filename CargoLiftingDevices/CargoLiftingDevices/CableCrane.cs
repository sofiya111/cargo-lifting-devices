using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLiftingDevices
{
  /// <summary>
  /// Кабельный кран
  /// </summary>
  public class CableCrane : Crane
  {
    /// <summary>
    /// Размер пролета
    /// </summary>
    private int _spanSize;
    /// <summary>
    /// Размер пролета
    /// </summary>
    public int SpanSize
    {
      get
      {
        return _spanSize;
      }
      set
      {
        _spanSize = value;
      }
    }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parName">Название устройства для подъема груза</param>
    /// <param name="parCarryingCapacity">Грузоподъемность</param>
    /// <param name="parLiftingHeight">Высота подъема</param>
    /// <param name="parCraneBoomLength">Длина стрелы крана</param>
    /// <param name="parSpanSize">Размер пролета</param>
    public CableCrane(string parName, int parCarryingCapacity, int parLiftingHeight, int parCraneBoomLength, int parSpanSize) :
        base(parName, parCarryingCapacity, parLiftingHeight, parCraneBoomLength)
    {
      _spanSize = parSpanSize;
    }
  }
}
