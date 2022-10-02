
using System;
using System.Collections.Generic;
 
class Graph {
    private int V; // Số đỉnh

    // Mảng các danh sách liên kết
    // Mỗi danh sách liên kết đại diện cho một đỉnh
    private List<int>[] adj;

    // Constructor
    Graph(int v)
    {
        V = v;
        adj = new List<int>[ v ];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    // Hàm thêm cạnh vào đồ thị
    void AddEdge(int v, int w)
    {
        adj[v].Add(w); // Thêm w vào list v
    }
 
    // Hàm sử dụng DFS
    void DFSUtil(int v, bool[] visited)
    {
        // Đánh dấu đỉnh hiện tại đã được duyệt
        // và in ra màn hình
        visited[v] = true;
        Console.Write(v + " ");

        // Duyệt qua các đỉnh kề của đỉnh hiện tại
        // nếu chưa được duyệt thì gọi đệ quy
        List<int> vList = adj[v];
        foreach(var n in vList)
        {
            if (!visited[n])
                DFSUtil(n, visited);
        }
    }

    // Hàm duyệt DFS
    // Với đỉnh bắt đầu là v
    void DFS(int v)
    {
        // Khởi tạo mảng đánh dấu đã duyệt
        // ban đầu là false
        bool[] visited = new bool[V];

        // Gọi hàm duyệt DFSUtil
        // với đỉnh bắt đầu là v
        DFSUtil(v, visited);
    }

    // Driver Code
    public static void Main(String[] args)
    {
        Graph g = new Graph(8);
 
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(0, 3);
        g.AddEdge(1, 3);
        g.AddEdge(2, 4);
        g.AddEdge(3, 5);
        g.AddEdge(3, 6);
        g.AddEdge(4, 7);
        g.AddEdge(4, 5);
        g.AddEdge(5, 2);
        Console.WriteLine("DFS: "+"Bắt đầu từ đỉnh 0");
 
        // Hàm gọi
        g.DFS(0);
        Console.ReadKey();
    }
}
 