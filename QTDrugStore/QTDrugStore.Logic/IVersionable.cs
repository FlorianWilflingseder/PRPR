//@CodeCopy
//MdStart

namespace QTDrugStore.Logic
{
    public interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
