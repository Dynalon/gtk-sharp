// GtkSharp.Generation.GObjectGen.cs - The GObject generatable
//
// Note: This generatable only handles GObject* values. GObject subclasses
// are handled by ObjectGen.
//
// Author: Rachel Hestilow <rachel@nullenvoid.com>
//
// Copyright (c) 2004 Rachel Hestilow
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the GNU General Public
// License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace GtkSharp.Generation {

	public class GObjectGen : ManualGen {

		public GObjectGen () : base ("GObject", "GLib.Object") {}
		
		public override string FromNative(string var)
		{
			return "GLib.Object.GetObject (" + var + ")";
		}
	}
}
