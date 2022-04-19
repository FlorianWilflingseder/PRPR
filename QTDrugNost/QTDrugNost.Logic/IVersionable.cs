//@CodeCopy
//MdStart

namespace QTDrugNost.Logic
{
    public interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
