﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using SharpShell.Attributes;
using SharpShell.Pidl;
using SharpShell.SharpNamespaceExtension;

namespace TrivialNamespaceExtension
{
    
    [ComVisible(true)]
    [NamespaceExtensionJunctionPoint(NamespaceExtensionAvailability.Everyone, VirtualFolder.MyComputer, "Trivial Extension")]
    public class TrivialNamespaceExtension : SharpNamespaceExtension
    {
        public override AttributeFlags GetAttributes()
        {
            return 0;
        }

        public override IEnumerable<IShellNamespaceItem> EnumerateChildren(uint index, uint count, Targets flags)
        {
            yield break;
        }

        public override NamespaceExtensionRegistrationSettings GetRegistrationSettings()
        {
            return new NamespaceExtensionRegistrationSettings
            {
                ExtensionAttributes = AttributeFlags.IsFolder | AttributeFlags.MayContainSubFolders
            };
        }

        public override Control CreateView()
        {
            return new ExtensionViewControl();
        }
    }
}
