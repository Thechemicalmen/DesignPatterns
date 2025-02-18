using Observer;

var stockService = new StockService();

var obs1 = new Magasin1Observer();
var obs2 = new Magasin2Observer();

stockService.ArticlePriceUpdated += obs1.ReceivePriceChanged;
stockService.ArticlePriceUpdated += obs2.ReceivePriceChanged;

stockService.AddItemInStock(1, 100m);

stockService.ArticlePriceUpdated -= obs1.ReceivePriceChanged;

stockService.AddItemInStock(2, 50m);

stockService.ArticlePriceUpdated -= obs2.ReceivePriceChanged;