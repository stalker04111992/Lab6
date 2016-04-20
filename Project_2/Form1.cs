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


                    dataGridView1[2, 0].Value = "1";
                    dataGridView1[3, 0].Value = "1";
                    dataGridView1[5, 0].Value = "1";
                    dataGridView1[6, 0].Value = "1";

                    dataGridView1[2, 1].Value = "1";
                    dataGridView1[3, 1].Value = "1";
                    dataGridView1[5, 1].Value = "1";
                    dataGridView1[6, 1].Value = "1";

                    dataGridView1[1, 2].Value = "1";
                    dataGridView1[0, 2].Value = "1";
                    dataGridView1[6, 2].Value = "1";
                    dataGridView1[5, 2].Value = "1";

                    dataGridView1[0, 3].Value = "1";
                    dataGridView1[1, 3].Value = "1";
                    dataGridView1[5, 3].Value = "1";
                    dataGridView1[6, 3].Value = "1";

                    dataGridView1[5, 4].Value = "1";
                    dataGridView1[6, 4].Value = "1";

                    dataGridView1[3, 5].Value = "1";
                    dataGridView1[4, 5].Value = "1";
                    dataGridView1[2, 5].Value = "1";
                    dataGridView1[1, 5].Value = "1";
                    dataGridView1[0, 5].Value = "1";

                    dataGridView1[4, 6].Value = "1";
                    dataGridView1[3, 6].Value = "1";
                    dataGridView1[2, 6].Value = "1";
                    dataGridView1[1, 6].Value = "1";
                    dataGridView1[0, 6].Value = "1";


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




        #region DRAWING
      

        private void DrawGraphMatrix(List<Vertex> trees)
        {
          //  richTextBox1.Clear();
            var graphics = pictureBox1.CreateGraphics();
            int yMax = pictureBox1.Height;
            int xMax = pictureBox1.Width;
            graphics.Clear(pictureBox1.BackColor);


            int r = 360/2;

            double c = 2*Math.PI*r;



        }





        #endregion DRAWING

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var c = dataGridView1[e.ColumnIndex, e.RowIndex];
                if(c.Value!=null)
                    if(c.RowIndex!=c.ColumnIndex)
                c.Value = c.Value.ToString().Contains("0") ? "1" : "0";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var size = Int32.Parse(textBox1.Text);

            InitGrid(size);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            int size = dataGridView1.ColumnCount;

            int timeType0 = Convert.ToInt32(textBox4.Text);
            int timeType1 = Convert.ToInt32(textBox5.Text);

            GTypes.CountType0 = Convert.ToInt32(textBox2.Text);
            GTypes.CountType1 = Convert.ToInt32(textBox3.Text);

            GTypes.TimeType0 = timeType0*GTypes.CountType0;
            GTypes.TimeType1 = timeType1 * GTypes.CountType1;

            List<Vertex> g = (from DataGridViewCell b in dataGridView1.Rows[0].Cells
                                select new Vertex(dataGridView1.Columns[b.ColumnIndex].HeaderCell.GetIntValue(), (int) dataGridView1.Columns[b.ColumnIndex].HeaderCell.Tag, (int) dataGridView1.Columns[b.ColumnIndex].HeaderCell.Tag ==  0 ? timeType0 : timeType1)).ToList();

            if (!g.Any())
            {
                MessageBox.Show("Запоўніце і стварыць матрыцу, свой Нэа ў дадатак:)");
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
                    if(b.GetIntValue() == 1)
                        g.ElementAt(b.RowIndex).ChildrenVertices.Add(g.ElementAt(b.ColumnIndex));
                }
               
            }


            MainCycle(g);

            //DrawGraphMatrix(g);


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

                if(g.Count==0) break;;
               
            }
            richTextBox1.Text += "Final\n";
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
                
                DoFusion(plan, w, g);
            
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
            if(!inp.Any())   return;
            bool isParall = inp[0].IsParallel;

            if (!inp.TrueForAll(t => t.IsParallel == inp[0].IsParallel))
                throw new Exception("Нешта пайшло не так з алгарытмам выбаркі");

            var b = GetCounts(plan);

            Vertex fusion = new Vertex(b);

            if (isParall)
            {
                if (inp.Count % 2 != 0) ;//throw new Exception("Count is great!");

                if (IsTypeEnought(inp[0], inp[1], fusion))
                {
                    UpdateRef(main, fusion);
                }
            }
            else
            {
                if(inp.Count%2!=0) ;//throw new Exception("Count is great!");

                if (IsTypeEnought(inp[0], inp[1], fusion))
                {
                    UpdateRef(main, fusion);
                }
            }

            plan.RemoveAll(t => fusion.ChildrenVertices.Contains(t) && fusion.IsParallel);

            if(fusion.FusionVertices.Any() && (fusion.IsParallel || fusion.IsEmpty))
                plan.Add(fusion);

            Print(main);

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
            richTextBox1.Text +=$"Level----\n";
            foreach (var a in g)
            {
                richTextBox1.Text += a+$"\n";
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
            if (c.Count != 1 && c1.Count != 1) return false;

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
    }
}