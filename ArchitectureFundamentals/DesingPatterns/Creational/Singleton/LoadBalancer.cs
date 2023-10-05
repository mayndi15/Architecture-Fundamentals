namespace Architecture_Fundamentals.DesingPatterns.Creational.Singleton;

internal sealed class LoadBalancer
{
    private static readonly LoadBalancer Instance = new();

    private readonly List<Server> _servers;
    private readonly Random _random = new();

    private LoadBalancer()
    {
        _servers = new List<Server>
        {
            new() { Id = Guid.NewGuid(), Name = "ServerI", IP = "120.14.220.18" },
            new() { Id = Guid.NewGuid(), Name = "ServerII", IP = "120.14.220.19" },
            new() { Id = Guid.NewGuid(), Name = "ServerIII", IP = "120.14.220.20" },
            new() { Id = Guid.NewGuid(), Name = "ServerIV", IP = "120.14.220.21" },
            new() { Id = Guid.NewGuid(), Name = "ServerV", IP = "120.14.220.22" },
        };
    }

    public static LoadBalancer GetLoadBalancer()
    {
        return Instance;
    }

    public Server NextServer
    {
        get
        {
            var r = _random.Next(_servers.Count);
            return _servers[r];
        }
    }
}