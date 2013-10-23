﻿#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using ClearCanvas.Common;
using ClearCanvas.Desktop;
using ClearCanvas.Desktop.View.WinForms;
using ClearCanvas.ImageViewer.Clipboard.View.WinForms;
using ClearCanvas.ImageViewer.Tools.Reporting.KeyImages;

namespace ClearCanvas.ImageViewer.Tools.Reporting.View.WinForms
{
	[ExtensionOf(typeof (KeyImageClipboardComponentViewExtensionPoint))]
	public class KeyImageClipboardComponentView : WinFormsView, IApplicationComponentView
	{
		private KeyImageClipboardComponent _component;
		private KeyImageClipboardComponentControl _control;

		public void SetComponent(IApplicationComponent component)
		{
			_component = (KeyImageClipboardComponent) component;
		}

		public override object GuiElement
		{
			get { return _control ?? (_control = new KeyImageClipboardComponentControl(_component)); }
		}

		private class KeyImageClipboardComponentControl : ClipboardComponentControl
		{
			private readonly KeyImageClipboardComponent _component;

			public KeyImageClipboardComponentControl(KeyImageClipboardComponent component)
				: base(component)
			{
				_component = component;
			}
		}
	}
}