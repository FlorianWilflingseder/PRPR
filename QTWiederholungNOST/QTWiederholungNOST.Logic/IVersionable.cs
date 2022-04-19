//@CodeCopy
//MdStart

namespace QTWiederholungNOST.Logic
{
    public interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
//MdEnd
