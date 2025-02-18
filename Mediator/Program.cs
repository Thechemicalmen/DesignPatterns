using Mediator;

var mediator = new MyMediator();

mediator.RegisterHandler(new AcheterArticleHandler());

await mediator.Handle(new AcheterArticle("Marteau"));