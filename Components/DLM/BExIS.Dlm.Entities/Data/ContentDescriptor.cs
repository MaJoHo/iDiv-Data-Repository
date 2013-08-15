﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vaiona.Entities.Common;

namespace BExIS.Dlm.Entities.Data
{
    public class ContentDescriptor: BaseEntity
    {
        #region Attributes
        
        public virtual Int32 OrderNo { get; set; }
        public virtual string MimeType { get; set; }
        public virtual string Name { get; set; }
        public virtual string URI { get; set; }

        #endregion
        
        #region Associations

        public virtual DatasetVersion DatasetVersion { get; set; } // inverse map

        #endregion

        #region Mathods
        #endregion

    }
}
