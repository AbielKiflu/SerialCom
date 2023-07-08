using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace SerialPortVirtual
{

    public class STLModel
    {
        private Vector3[] vertices;

        public void Load(string filePath)
        {
            // Read the STL file data and extract the vertex information
            var lines = File.ReadAllLines(filePath);
            var vertexList = new List<Vector3>();

            // Parse the STL file data to extract the vertex coordinates
            // Each vertex consists of three float values (x, y, z) on separate lines
            for (int i = 0; i < lines.Length; i += 7)
            {
                if (lines[i].StartsWith("vertex"))
                {
                    var vertex1 = ParseVertex(lines[i]);
                    var vertex2 = ParseVertex(lines[i + 1]);
                    var vertex3 = ParseVertex(lines[i + 2]);

                    vertexList.Add(vertex1);
                    vertexList.Add(vertex2);
                    vertexList.Add(vertex3);
                }
            }

            // Convert the vertex list to an array
            vertices = vertexList.ToArray();
        }

        private Vector3 ParseVertex(string line)
        {
            var values = line.Split(' ');
            float x = float.Parse(values[1]);
            float y = float.Parse(values[2]);
            float z = float.Parse(values[3]);

            return new Vector3(x, y, z);
        }

        public void Render()
        {
            // Render the STL model using OpenGL

            // Begin rendering
            GL.Begin(PrimitiveType.Triangles);

            // Render each triangle in the model
            foreach (var vertex in vertices)
            {
                GL.Vertex3(vertex);
            }

            // End rendering
            GL.End();
        }
    }
}
