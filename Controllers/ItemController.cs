using Microsoft.AspNetCore.Mvc;
using RankingApp.Models;

namespace RankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id =1, title = "The Godfather", imageId=1, Ranking=0,ItemType=1 },
            new ItemModel{Id =2, title = "Highlander", imageId=2, Ranking=0,ItemType=1 },
            new ItemModel{Id =3, title = "Highlander II", imageId=3, Ranking=0,ItemType=1 },
            new ItemModel{Id =4, title = "The Last of the Mohicans", imageId=4, Ranking=0,ItemType=1 },
            new ItemModel{Id =5, title = "Police Academy 6", imageId=5, Ranking=0,ItemType=1 },
            new ItemModel{Id =6, title = "Rear Window", imageId=6, Ranking=0,ItemType=1 },
            new ItemModel{Id =7, title = "Road House", imageId=7, Ranking=0,ItemType=1 },
            new ItemModel{Id =8, title = "The Shawshank Redemption", imageId=8, Ranking=0,ItemType=1 },
            new ItemModel{Id =9, title = "Star Treck IV", imageId=9, Ranking=0,ItemType=1 },
            new ItemModel{Id =10, title = "Superman 4", imageId=10, Ranking=0,ItemType=1 },
            new ItemModel{Id = 11, title = "Abbey Road", imageId=11, Ranking=0,ItemType=2 },
            new ItemModel{Id = 12, title = "Adrenalize", imageId=12, Ranking=0,ItemType=2 },
            new ItemModel{Id = 13, title = "Back in Black", imageId=13, Ranking=0,ItemType=2 },
            new ItemModel{Id = 14, title = "Enjoy the Silence", imageId=14, Ranking=0,ItemType=2 },
            new ItemModel{Id = 15, title = "Parachutes", imageId=15, Ranking=0,ItemType=2 },
            new ItemModel{Id = 16, title = "Ride the Lightning", imageId=16, Ranking=0,ItemType=2 },
            new ItemModel{Id = 17, title = "Rock or Bust", imageId=17, Ranking=0,ItemType=2 },
            new ItemModel{Id = 18, title = "Rust in Peace", imageId=18, Ranking=0,ItemType=2 },
            new ItemModel{Id = 19, title = "St. Anger", imageId=19, Ranking=0,ItemType=2 },
            new ItemModel{Id = 20, title = "The Final Countdown", imageId=20, Ranking=0,ItemType=2 }

        };

        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            System.Threading.Thread.Sleep(2000);
            return items;
        }
    }
}