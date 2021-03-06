//
// doc-bootstrap.cs: Stub support for XML documentation.
//
// Author:
//	Raja R Harinath <rharinath@novell.com>
//
// Dual licensed under the terms of the MIT X11 or GNU GPL
//
// Copyright 2004 Novell, Inc.
//
//

#if BOOTSTRAP_WITH_OLDLIB || NET_2_1

using XmlElement = System.Object;

namespace Mono.CSharp {
	public class DocUtil
	{
		internal static void GenerateTypeDocComment (TypeContainer t, DeclSpace ds)
		{
		}

		internal static void GenerateDocComment (MemberCore mc, DeclSpace ds)
		{
		}

		public static string GetMethodDocCommentName (MemberCore mc, Parameters p, DeclSpace ds)
		{
			return "";
		}

		internal static void OnMethodGenerateDocComment (MethodCore mc, XmlElement el)
		{
		}

		public static void GenerateEnumDocComment (Enum e, DeclSpace ds)
		{
		}
	}

	public class Documentation
	{
		public Documentation (string xml_output_filename)
		{
		}

		public bool OutputDocComment (string asmfilename)
		{
			return true;
		}

		public void GenerateDocComment ()
		{
		}
	}
}

#endif
