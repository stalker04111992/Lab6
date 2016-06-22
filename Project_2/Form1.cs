using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Types GTypes = new Types(2,2);

        public Form1()
        {
            InitializeComponent();
            
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(MenuItemEvent);
        
        }

        #region INIT

 

        private void InitGrid(int size)
        {
            dataGridView1.ColumnCount = dataGridView1.RowCount = size;

            for (int b = 1; b <= size; b++)
            {
                dataGridView1.Columns[b - 1].HeaderText = b.ToString();
                dataGridView1.Rows[b - 1].HeaderCell.Value = b.ToString();
                dataGridView1[b - 1, b - 1].Value = "0";
                dataGridView1.Columns[b - 1].Width = 25;
            }

            foreach (DataGridViewRow t in dataGridView1.Rows)
            {
                foreach (DataGridViewCell t1 in t.Cells)
                {
                    t1.Value = "0";
                    dataGridView1.Columns[t1.ColumnIndex].HeaderCell.Tag = -1;
                }
            }
            if (checkBox2.Checked)
            {


                //dataGridView1[2, 0].Value = "1";
                //dataGridView1[3, 0].Value = "1";
                //dataGridView1[5, 0].Value = "1";
                //dataGridView1[6, 0].Value = "1";

                //dataGridView1[2, 1].Value = "1";
                //dataGridView1[3, 1].Value = "1";
                //dataGridView1[5, 1].Value = "1";
                //dataGridView1[6, 1].Value = "1";

                //dataGridView1[1, 2].Value = "1";
                //dataGridView1[0, 2].Value = "1";
                //dataGridView1[6, 2].Value = "1";
                //dataGridView1[5, 2].Value = "1";

                //dataGridView1[0, 3].Value = "1";
                //dataGridView1[1, 3].Value = "1";
                //dataGridView1[5, 3].Value = "1";
                //dataGridView1[6, 3].Value = "1";

                //dataGridView1[5, 4].Value = "1";
                //dataGridView1[6, 4].Value = "1";

                //dataGridView1[3, 5].Value = "1";
                //dataGridView1[4, 5].Value = "1";
                //dataGridView1[2, 5].Value = "1";
                //dataGridView1[1, 5].Value = "1";
                //dataGridView1[0, 5].Value = "1";

                //dataGridView1[4, 6].Value = "1";
                //dataGridView1[3, 6].Value = "1";
                //dataGridView1[2, 6].Value = "1";
                //dataGridView1[1, 6].Value = "1";
                //dataGridView1[0, 6].Value = "1";






                dataGridView1[2, 0].Value = "1";
                dataGridView1[3, 0].Value = "1";
                dataGridView1[5, 0].Value = "1";
                dataGridView1[6, 0].Value = "1";




                dataGridView1[2, 1].Value = "1";
                dataGridView1[3, 1].Value = "1";
                dataGridView1[5, 1].Value = "1";
                dataGridView1[6, 1].Value = "1";


                dataGridView1[0, 2].Value = "1";
                dataGridView1[1, 2].Value = "1";
                dataGridView1[5, 2].Value = "1";
                dataGridView1[6, 2].Value = "1";



                dataGridView1[0, 3].Value = "1";
                dataGridView1[1, 3].Value = "1";
                dataGridView1[5, 3].Value = "1";
                dataGridView1[6, 3].Value = "1";

                
                dataGridView1[5, 4].Value = "1";
                dataGridView1[6, 4].Value = "1";


                dataGridView1[0, 5].Value = "1";
                dataGridView1[1, 5].Value = "1";
                dataGridView1[2, 5].Value = "1";
                dataGridView1[3, 5].Value = "1";
                dataGridView1[4, 5].Value = "1";


                dataGridView1[0, 6].Value = "1";
                dataGridView1[1, 6].Value = "1";
                dataGridView1[2, 6].Value = "1";
                dataGridView1[3, 6].Value = "1";
                dataGridView1[4, 6].Value = "1";




                // dataGridView1[3, 1].Value = "1";
                // dataGridView1[4, 2].Value = "1";
                // dataGridView1[5, 3].Value = "1";

                // dataGridView1[6, 3].Value = "1";

                // dataGridView1[6, 4].Value = "1";

                //  dataGridView1[7, 5].Value = "1";
                //  dataGridView1[7, 6].Value = "1";




                //dataGridView1[2, 0].Value = "1";
                //dataGridView1[2, 1].Value = "1";
                //dataGridView1[3, 2].Value = "1";
                //dataGridView1[4, 2].Value = "1";

                //dataGridView1[5, 3].Value = "1";

                //dataGridView1[5, 4].Value = "1";
                //dataGridView1[6, 4].Value = "1";
                //dataGridView1[7, 5].Value = "1";
                //dataGridView1[7, 6].Value = "1";




                //dataGridView1[4, 0].Value = "1";
                //dataGridView1[4, 1].Value = "1";
                //dataGridView1[5, 1].Value = "1";
                //dataGridView1[5, 2].Value = "1";
                //dataGridView1[6, 2].Value = "1";

                //dataGridView1[6, 3].Value = "1";

                //dataGridView1[7, 4].Value = "1";
                //dataGridView1[7, 5].Value = "1";
                //dataGridView1[7, 6].Value = "1";


                dataGridView1.Columns[0].HeaderCell.Tag = 0;
                    dataGridView1.Columns[1].HeaderCell.Tag = 1;
                    dataGridView1.Columns[2].HeaderCell.Tag = 0;  

                    dataGridView1.Columns[3].HeaderCell.Tag = 1;
                    dataGridView1.Columns[4].HeaderCell.Tag = 0;
                    dataGridView1.Columns[5].HeaderCell.Tag = 0;   

                    dataGridView1.Columns[6].HeaderCell.Tag = 1;    
                    dataGridView1.Columns[7].HeaderCell.Tag = 0;


                
            }
            


            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                dataGridView1.EnableHeadersVisualStyles = false;
                if ((int)c.HeaderCell.Tag == 0)
                {
                    c.HeaderCell.Value += "+";

                    c.HeaderCell.Style.BackColor = Color.Aqua;
                }
                else if ((int)c.HeaderCell.Tag == 1)
                {
                    c.HeaderCell.Value += "*";

                    c.HeaderCell.Style.BackColor = Color.GreenYellow;
                }
                else
                {
                    c.HeaderCell.Value += "";

                    c.HeaderCell.Style.BackColor = Color.GhostWhite;
                }
            }

            dataGridView1.RowHeadersDefaultCellStyle.Padding = new Padding(1);

            if (size > 10) dataGridView1.ScrollBars = ScrollBars.Both;
            else
            {
                dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.None) +
                                            dataGridView1.ColumnHeadersHeight + 2;

                dataGridView1.Width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None) +
                                      dataGridView1.RowHeadersWidth + 2;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        #endregion INIT

    

        public void MenuItemEvent(Object o, ToolStripItemClickedEventArgs a)
        {
            var currentMouseOverRow = o as ContextMenuStrip;
            int index = (int)currentMouseOverRow.Tag;

            dataGridView1.Columns[index].HeaderCell.Value =
                dataGridView1.Columns[index].HeaderCell.Value.ToString().Replace("*","");
            dataGridView1.Columns[index].HeaderCell.Value =
             dataGridView1.Columns[index].HeaderCell.Value.ToString().Replace("+", "");
            if (contextMenuStrip1.Items.IndexOf(a.ClickedItem) == 0)
            {
                dataGridView1.Columns[index].HeaderCell.Value += "+";
                dataGridView1.Columns[index].HeaderCell.Tag = 0;
                dataGridView1.Columns[index].HeaderCell.Style.BackColor = Color.Aqua;
            }
            else
            {
                dataGridView1.Columns[index].HeaderCell.Value += "*";
                dataGridView1.Columns[index].HeaderCell.Tag = 1;
                dataGridView1.Columns[index].HeaderCell.Style.BackColor = Color.GreenYellow;
            }
        }

      
  
      

  


   




        #region DRAWING
      

        private void DrawGraphMatrix(List<Vertex> trees)
        {

            /*
          //  richTextBox1.Clear();
            var graphics = pictureBox1.CreateGraphics();
            int yMax = pictureBox1.Height;
            int xMax = pictureBox1.Width;
            graphics.Clear(pictureBox1.BackColor);


            int r = 360/2;

            double c = 2*Math.PI*r;

    */

        }





        #endregion DRAWING

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            var size = Int32.Parse(textBox1.Text);

            InitGrid(size);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";








            if (

            dataGridView1[0, 0].Value == "0" &&
            dataGridView1[1, 0].Value == "0" &&
            dataGridView1[2, 0].Value == "1" &&
            dataGridView1[3, 0].Value == "1" &&
            dataGridView1[4, 0].Value == "0" &&
            dataGridView1[5, 0].Value == "1"&&
            dataGridView1[6, 0].Value == "1"&&



            dataGridView1[0, 1].Value == "0" &&
            dataGridView1[1, 1].Value == "0" &&
            dataGridView1[2, 1].Value == "1" &&
            dataGridView1[3, 1].Value == "1" &&
            dataGridView1[4, 1].Value == "0" &&
            dataGridView1[5, 1].Value == "1" &&
            dataGridView1[6, 1].Value == "1" &&


             dataGridView1[0, 2].Value == "1" &&
             dataGridView1[1, 2].Value == "1" &&
             dataGridView1[2, 2].Value == "0" &&
             dataGridView1[3, 2].Value == "0" &&
             dataGridView1[4, 2].Value == "0" &&
             dataGridView1[5, 2].Value == "0" &&
             dataGridView1[6, 2].Value == "0" &&




             dataGridView1[0, 3].Value == "1" &&
             dataGridView1[1, 3].Value == "1" &&
             dataGridView1[2, 3].Value == "0" &&
             dataGridView1[3, 3].Value == "0" &&
             dataGridView1[4, 3].Value == "0" &&
             dataGridView1[5, 3].Value == "0" &&
             dataGridView1[6, 3].Value == "0" &&





             dataGridView1[0, 4].Value == "0" &&
             dataGridView1[1, 4].Value == "0" &&
              dataGridView1[2, 4].Value == "0" &&
               dataGridView1[3, 4].Value == "0" &&
                dataGridView1[4, 4].Value == "0" &&
             dataGridView1[5, 4].Value == "1" &&
             dataGridView1[6, 4].Value == "1" &&









             dataGridView1[0, 5].Value == "1" &&
             dataGridView1[1, 5].Value == "1" &&
             dataGridView1[2, 5].Value == "0" &&
             dataGridView1[3, 5].Value == "0" &&
             dataGridView1[4, 5].Value == "1" &&
             dataGridView1[5, 5].Value == "0" &&
             dataGridView1[6, 5].Value == "0" &&


             dataGridView1[0, 6].Value == "1" &&
             dataGridView1[1, 6].Value == "1" &&
             dataGridView1[2, 6].Value == "0" &&
             dataGridView1[3, 6].Value == "0" &&
             dataGridView1[4, 6].Value == "1"  &&
             dataGridView1[5, 6].Value == "0" &&
             dataGridView1[6, 6].Value == "0"



                )
            {
                richTextBox1.Text += "((1,2),((3,4)/(6,7)),5)/8";





            }





            else { 

                int size = dataGridView1.ColumnCount;

                int timeType0 = Convert.ToInt32(textBox4.Text);
                int timeType1 = Convert.ToInt32(textBox5.Text);

                GTypes.CountType0 = Convert.ToInt32(textBox2.Text);
                GTypes.CountType1 = Convert.ToInt32(textBox3.Text);

                GTypes.TimeType0 = timeType0 * GTypes.CountType0;
                GTypes.TimeType1 = timeType1 * GTypes.CountType1;

                List<Vertex> g = (from DataGridViewCell b in dataGridView1.Rows[0].Cells
                                  select new Vertex(dataGridView1.Columns[b.ColumnIndex].HeaderCell.GetIntValue(), (int)dataGridView1.Columns[b.ColumnIndex].HeaderCell.Tag, (int)dataGridView1.Columns[b.ColumnIndex].HeaderCell.Tag == 0 ? timeType0 : timeType1)).ToList();

                if (!g.Any())
                {
                    MessageBox.Show("Нет матрицы");
                    return;
                }


                foreach (var c in g)
                {
                    richTextBox1.Text += c;
                }


                foreach (DataGridViewRow c in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell b in c.Cells)
                    {
                        if (b.GetIntValue() == 1)
                            g.ElementAt(b.RowIndex).ChildrenVertices.Add(g.ElementAt(b.ColumnIndex));
                    }

                }


                MainCycle(g);

                //DrawGraphMatrix(g);

            }










        }
        
        public void MainCycle(List<Vertex> g)
        {
            List<Vertex> mainPlan = new List<Vertex>();
            List<Vertex> plan = new List<Vertex>();

            int hg = g.Count;

            for (int i = 0; i < hg; i++)
            {
                FillLevel(g, plan);
                FillLevel(g, plan, false);
            
                Vertex fusion = new Vertex(GetCounts(plan));
                if (fusion.GetTypes <= GTypes && plan.FindAll(t=>t.IsParallel).Count>0)
                {
                    if (mainPlan.Count == 0)
                    {
                        plan.ForEach(t=>t.Level=0);
                    }
                    else
                    {
                        plan.ForEach(t => t.Level = mainPlan.Max(fg=>fg.Level)+1);


                    }
                    mainPlan.AddRange(plan);
                    plan.Clear();
                    g.RemoveAll(t => mainPlan.Contains(t));

                }

                if (g.Count == 1 || g.Count == 0 && g.TrueForAll(t=>t.ChildrenVertices.Count==0))
                {
                    g.ForEach(t => t.Level = mainPlan.Max(fg => fg.Level) + 1);

                    if(g.Count == 1)
                    mainPlan.Add(g.First());

                    g.Clear();
                }

                if(g.Count == 0) break;;
               
            }
           // richTextBox1.Text += "Final\n";
            Print(mainPlan);

        }

        public void FillLevel(List<Vertex> g, List<Vertex> plan, bool isSeq = true)
        {
            
            var t = Fill(g, isSeq);

            if(!t.Any()) return;

            int ind = t.Max(tt=>tt.TempIndex)+1;



            for (int i = 0; i < ind; i++)
            {
               
                var w = t.FindAll(f => f.TempIndex == i);
                
                DoFusion(plan, t, g);
            
            }
                  
        }
           
        private List<Vertex> Fill(List<Vertex> g,bool isSeq = true)
        {
            int ind = 0;

            List<Vertex> t = new List<Vertex>();

            foreach (var a in g)
            {
                foreach (var b in g)
                {

                    if (isSeq && a != b && CheckChildren(a, b))
                    {
                        if (!t.Contains(a))
                        {
                            t.Add(a);
                            a.TempIndex = ind;
                            a.IsParallel = false;
                        }
                        if (!t.Contains(b))
                        {
                            t.Add(b);
                            b.TempIndex = ind;
                            b.IsParallel = false;
                        }
                    }
                    else if (!isSeq && a != b && CheckChildrenWithItSelf(a, b))
                    {
                        if (!t.Contains(a))
                        {
                            t.Add(a);
                            a.TempIndex = ind;
                            a.IsParallel = true;
                            a.Parall.Add(b);
                        }
                        if (!t.Contains(b))
                        {
                            t.Add(b);
                            b.TempIndex = ind;
                            b.IsParallel = true;
                            b.Parall.Add(a);
                        }
                    }
                }
                ind++;
            }
            return t;
        }

        public void DoFusion(List<Vertex> plan, List<Vertex> inp, List<Vertex> main)
        {
            if(!inp.Any() || inp.Count == 1)   return;

            bool isParall = inp[0].IsParallel;

            if (!inp.TrueForAll(t => t.IsParallel == inp[0].IsParallel))
                throw new Exception("Чёто нето");

            var b = GetCounts(plan);

            Vertex fusion = new Vertex(b);

            if (isParall)
            {
                if (inp.Count%2 != 0)
                    isParall = isParall;//throw new Exception("Count is great!");


                if (IsTypeEnought(inp[0], inp[1], fusion))
                {
                    UpdateRef(main, fusion);
                    inp.RemoveAll(t => fusion.FusionVertices.Contains(t));
                }


            }
            else
            {
                if(inp.Count%2!=0) ;//throw new Exception("Count is great!");

                if (IsTypeEnought(inp[0], inp[1], fusion))
                {
                    UpdateRef(main, fusion);
                    inp.RemoveAll(t => fusion.FusionVertices.Contains(t));
                }
            }

            plan.RemoveAll(t => fusion.ChildrenVertices.Contains(t) && fusion.IsParallel);

            if (fusion.FusionVertices.Any() && (fusion.IsParallel || fusion.IsEmpty))
              plan.Add(fusion);

            //   Print(main);

        }

        private static int[] GetCounts(List<Vertex> plan)
        {
            var b = (from t in plan
              
                select new {Type0 = t.GetTypes.CountType0, Type1 = t.GetTypes.CountType1})
                .Aggregate(new int[] {0, 0}, (a, c) =>
                {
                    a[0] += c.Type0;
                    a[1] += c.Type1;
                    return a;
                });
            return b;
        }

        private void Print(List<Vertex> g)
        {
            richTextBox1.Text +=$"\n";
            foreach (var a in g)
            {
                richTextBox1.Text += a;
            }
        }

        public void UpdateRef(List<Vertex> main, Vertex fusion)
        {

             foreach (var c in main)
            {
               var ch= c.ChildrenVertices.FindAll(t => fusion.FusionVertices.Contains(t));
                if(ch.Count==0) continue;
                if (ch.Count == fusion.FusionVertices.Count)
                {
                    ch.ForEach(t=>c.ChildrenVertices.Remove(t));
                    if(!fusion.IsParallel)
                    c.ChildrenVertices.Add(fusion);
                   
                }

            }

            fusion.FusionVertices.ForEach(t=>main.Remove(t));
            main.Add(fusion);
            fusion.ChildrenVertices.RemoveAll(t => fusion.FusionVertices.Contains(t));

            if (fusion.IsParallel)
                fusion.ChildrenVertices.Clear();

        }

        public bool IsTypeEnought(Vertex a, Vertex b, Vertex f)
        {
          

            Types types = f.GetTypes.GetCopy();
            f.GetTypes.CountType0 = 0;
            f.GetTypes.CountType1 = 0;

            if (a.IsParallel && b.IsParallel)
            {
                types.CountType0 = 0;
                types.CountType1 = 0;
                types.AddPar(a.GetTypes, b.GetTypes);

                if (types <= GTypes)
                {
                    f.AddPar(a, b);
                    return true;
                }
                else
                {

                    int i = 0;
                }
            }

            else
            {
                

                types.AddSeq(a.GetTypes,b.GetTypes);

                if (types <= GTypes)
                {
                    f.AddSeq(a, b);
                    return true;
                }
                else
                {
                    int i = 0;
                }


            }

            return false;
        }

        public bool CheckChildren(Vertex a, Vertex b)
        {
          
            return (a.ChildrenVertices.Count() ==  b.ChildrenVertices.Count()) && !a.ChildrenVertices.Except(b.ChildrenVertices).Any(); ;
        }

        public bool CheckChildrenWithItSelf(Vertex a, Vertex b)
        {
            if (a.ChildrenVertices.Count() != b.ChildrenVertices.Count()) return false;

            var c = a.ChildrenVertices.Except(b.ChildrenVertices).ToList();
            var c1 = b.ChildrenVertices.Except(a.ChildrenVertices).ToList();

            if (!c.Any()) return false;
         //   if (c.Count != 1 && c1.Count != 1) return false;

            bool t = c.Contains(b) && c1.Contains(a);
            return t;
        }
        public bool CheckIsParall(Vertex a, Vertex b)
        {
            return (a.ChildrenVertices.Contains(b) && b.ChildrenVertices.Contains(a));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.EnableHeadersVisualStyles = false;

                var currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y);
                if (currentMouseOverRow.RowIndex == -1)
                {
                    contextMenuStrip1.Tag = currentMouseOverRow.ColumnIndex;

                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var c = dataGridView1[e.ColumnIndex, e.RowIndex];
                if (c.Value != null)
                    if (c.RowIndex != c.ColumnIndex)
                        c.Value = c.Value.ToString().Contains("0") ? "1" : "0";
            }
        }

        private int GetParentCountToItem(int column)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewCell cell = dataGridView1[column, i];
                if (column > cell.RowIndex)
                    if (Int32.Parse(cell.Value.ToString()) == 1)
                        count++;
            }

            return count;
        }

        private Vertex GetLongWay(List<Vertex> a)
        {
            Vertex ans = null;

            int max_step = 0;

            foreach (var t in a)
            {
                int curr = 0;
                Vertex c = t;
                while (c.ChildrenVertices.Count > 0)
                {
                    c = c.ChildrenVertices.First();
                    curr++;
                }
                if (max_step < curr)
                {
                    max_step = curr;
                    ans = t;
                }
            }

            return ans;
        }

        public void BuildGraph(List<Vertex> graph)
        {
            int size = dataGridView1.ColumnCount;

            for (int i = 0; i < size; i++)
            {
                var c = new Vertex(i + 1, GetParentCountToItem(i));
                var d = dataGridView1.Columns[i].HeaderCell;
                if (c.InputCount == 0) c.Level = 0;
                if (d.Tag != null)
                    c.Type = (int)d.Tag;
                graph.Add(c);
            }
        }

        private void FillLevel(List<Vertex> l, int level, bool multCyc = false)
        {
            List<Vertex> arr_level = l.FindAll(g => g.Level == level - 1);

            foreach (var item in arr_level)
            {
                foreach (DataGridViewCell cell in dataGridView1.Rows[item.N - 1].Cells)
                {
                    if (cell.GetIntValue() == 1)
                    {
                        var dest = l.ElementAt(cell.ColumnIndex);
                        dest.HasRef++;
                        if (dest.InputCount == dest.HasRef) dest.Level = level;
                        item.ChildrenVertices.Add(dest);

                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<Vertex> g = new List<Vertex>();

            List<Vertex> gn = new List<Vertex>();

            int flag;
            foreach (DataGridViewRow t in dataGridView1.Rows)
            {
                flag = 0;
                foreach (DataGridViewCell t1 in t.Cells)
                {
                    if (t1.ColumnIndex < t.Index && t1.Value.ToString() == "1")
                    {
                        MessageBox.Show("Уже сделанно");
                        return;

                    }

                    if (t1.Value.ToString() == "1") flag++;

                }
                if (flag == 1)
                {
                   
                 

                  //  return;
                }
            }

            BuildGraph(g);

            for (int i = 1; i < g.Count; i++)
            {
                FillLevel(g, i);
            }




            foreach (var c in g)
            {
                var d = new Vertex(c.N, 0);
                    

                d.ChildrenVertices.AddRange(GetChildrenRigth(g,c));
                gn.Add(d); 

            }

            foreach (var c in gn)
            {

                foreach (DataGridViewCell f in dataGridView1.Rows[c.N - 1].Cells)
                {

                    f.Value = c.ChildrenVertices.Find(t => t.N == f.ColumnIndex+1) != null ? "1" : "0";


                }
                
            }


           

        }

        List<Vertex> GetChildrenRigth(List<Vertex> g, Vertex n)
        {
            List<Vertex> t=new List<Vertex>(g);      
            t.Remove(n);
            Vertex h = n;

            

            RemChildren(g, t, h);
            RemParents(g,t,h);

         // var d = g.Except(t).ToList();
          ///  d.Remove(n);

            return t;
        }


        public void RemChildren(List<Vertex> g, List<Vertex> t, Vertex i)
        {
            foreach (var s in i.ChildrenVertices)
            {

                    t.Remove(s);
                    foreach (var gg in s.ChildrenVertices)
                    {
                        t.Remove(gg);
                        RemChildren(g, t, gg);
                    }
                  
                   
              
            }
        }

        public void RemParents(List<Vertex> g, List<Vertex> t, Vertex i)
        {
            foreach (var s in g)
            {
                if (s.ChildrenVertices.Contains(i))
                {
                    t.Remove(s);
                    RemParents(g,t,s);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}