using Kerstboom;


IKerstBoom boom = new BallenDecorator( new KerstBoom());

boom = new LichtDecorator(boom);



boom.Decorate();