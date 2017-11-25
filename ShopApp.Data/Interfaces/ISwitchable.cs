using ShopApp.Data.Enums;

namespace ShopApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}