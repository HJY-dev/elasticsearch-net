using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Indices
{
	public class DeleteAliasPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("indices/delete-alias.asciidoc:12")]
		public void Line12()
		{
			// tag::bdeee37db5fbf55e5026746c37df3c31[]
			var response0 = new SearchResponse<object>();
			// end::bdeee37db5fbf55e5026746c37df3c31[]

			response0.MatchesExample(@"DELETE /twitter/_alias/alias1");
		}
	}
}