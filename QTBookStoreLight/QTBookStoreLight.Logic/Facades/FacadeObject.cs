//@CodeCopy
//MdStart

using QTBookStoreLight.Logic.Controllers;

namespace QTBookStoreLight.Logic.Facades
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
