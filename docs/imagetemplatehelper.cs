using System;		
using System.Collections.Generic;
public class Program
{
	public static void Main()
	{

		List<string> values = new List<string>()
		{
			
"images/vineyard/planting/bent_bolts.jpg",
"images/vineyard/planting/bucket_in_hole.jpg",
"images/vineyard/planting/bucket.jpg",
"images/vineyard/planting/buckets_water.jpg",
"images/vineyard/planting/buckets_water2.jpg",
"images/vineyard/planting/chainsaw_gear.jpg",
"images/vineyard/planting/complete_trellis.jpg",
"images/vineyard/planting/complete_trellis2.jpg",
"images/vineyard/planting/cut_tree.jpg",
"images/vineyard/planting/cut_tree2.jpg",
"images/vineyard/planting/digging.jpg",
"images/vineyard/planting/dump_truck.jpg",
"images/vineyard/planting/hole.jpg",
"images/vineyard/planting/holes_full_of_water.jpg",
"images/vineyard/planting/holes_in_rows.jpg",
"images/vineyard/planting/irrigation_done2.jpg",
"images/vineyard/planting/irrigation_installed.jpg",
"images/vineyard/planting/jackhamer.jpg",
"images/vineyard/planting/laying_out_rows.jpg",
"images/vineyard/planting/laying_out_rows2.jpg",
"images/vineyard/planting/painted_trellis.jpg",
"images/vineyard/planting/painted_trellis2.jpg",
"images/vineyard/planting/pigtail.jpg",
"images/vineyard/planting/planted_vineyard.jpg",
"images/vineyard/planting/rebar.jpg",
"images/vineyard/planting/row_view.jpg",
"images/vineyard/planting/running_irrigation.jpg",
"images/vineyard/planting/several_end_posts.jpg",
"images/vineyard/planting/single_end_post_in_ground.jpg",
"images/vineyard/planting/single_end_post.jpg",
"images/vineyard/planting/single_hole.jpg",
"images/vineyard/planting/spraying.jpg",
"images/vineyard/planting/sucker_rod.jpg",
"images/vineyard/planting/support_post.jpg",
"images/vineyard/planting/trailer_contents.jpg",
"images/vineyard/planting/trailer.jpg",
"images/vineyard/planting/tree_crew.jpg",
"images/vineyard/planting/tree_perilous.jpg",
"images/vineyard/planting/trellis_jig.jpg",
"images/vineyard/planting/trellis_wire.jpg",
"images/vineyard/planting/trellis_wire2.jpg",
"images/vineyard/planting/trellis_wire3.jpg",
"images/vineyard/planting/view_east.jpg",
"images/vineyard/planting/view_from_ne_corner_pre_contruction.jpg"
		};
		
		foreach(var value in values)
		{
			string template = @"{{<image src=""" + value + @""" caption="""" alt=""alter-text"" height="""" width="""" position=""center"" 
			command=""fill"" option=""q3"" class=""img-fluid"" webp=""true"" >}}";
			Console.WriteLine(template);
		}
			
	}
}