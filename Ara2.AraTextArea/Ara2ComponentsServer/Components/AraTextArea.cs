// Copyright (c) 2010-2016, Rafael Leonel Pontani. All rights reserved.
// For licensing, see LICENSE.md or http://www.araframework.com.br/license
// This file is part of AraFramework project details visit http://www.arafrework.com.br
// AraFramework - Rafael Leonel Pontani, 2016-4-14
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using Ara2;
using Ara2.Components.Textbox;
using Ara2.Dev;

namespace Ara2.Components
{
    [Serializable]
    [AraDevComponent(vConteiner:false, vResizable:false)]
    public class AraTextArea : AraTextBox, IAraDev
    {

        public AraTextArea(IAraContainerClient ConteinerFather):
            base(AraObjectClienteServer.Create(ConteinerFather, "textarea"), ConteinerFather)
        {
            this.MinWidth = 10;
            this.MinHeight = 17;
            this.Width = 100;
            this.Height = 100;
        }

        public string NameType { get { return "Ara2.Components.AraTextArea"; } }
        public bool AraDevIsContainer { get { return false; } }
    }
}
