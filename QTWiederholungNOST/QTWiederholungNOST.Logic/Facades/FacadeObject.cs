//@CodeCopy
//MdStart

using QTWiederholungNOST.Logic.Controllers;

namespace QTWiederholungNOST.Logic.Facades
{
    public abstract class FacadeObject
    {
        internal ControllerObject ControllerObject { get; private set; }

        protected FacadeObject(ControllerObject controllerObject)
        {
            ControllerObject = controllerObject;
        }
    }
}

//MdEnd
