using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_2
{
    public class Types
    {
        public int CountType0;
        public int CountType1;

        public int TimeType0;
        public int TimeType1;

        public Types(int countType0, int countType1)
        {
            CountType0 = countType0;
            CountType1 = countType1;
        }

        public Types(Types t)
        {
            CountType0 = t.CountType0;
            CountType1 = t.CountType1;
            TimeType0 = t.TimeType0;
            TimeType1 = t.TimeType1;
        }

        public static bool operator ==(Types t1, Types t2)
        {
            if (ReferenceEquals(t1, t2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)t1 == null) || ((object)t2 == null))
            {
                return false;
            }
    
            return (t1.CountType0 == t2.CountType0 
                                  && t1.CountType1 == t2.CountType1);
        }

        public static bool operator !=(Types t1, Types t2)
        {
            if (ReferenceEquals(t1, t2))
            {
                return !true;
            }

            // If one is null, but not both, return false.
            if (((object)t1 == null) || ((object)t2 == null))
            {
                return !false;
            }
            return (t1.CountType0 != t2.CountType0 && t1.TimeType0 != t2.TimeType0
                                  && t1.CountType1 != t2.CountType1 && t1.TimeType1 != t2.TimeType1);
        }

        public static bool operator <=(Types t1, Types t2)
        {
            if (ReferenceEquals(t1, t2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)t1 == null) || ((object)t2 == null))
            {
                return false;
            }


            bool t = t1.TimeType0 <= t2.TimeType0 && t1.TimeType1 <= t2.TimeType1;

            t =  t && t1.CountType0 <= t2.CountType0 && t1.CountType1 <= t2.CountType1;

            return  t;
        }

        public static bool operator >=(Types t1, Types t2)
        {
            if (ReferenceEquals(t1, t2))
            {
                return !true;
            }

            // If one is null, but not both, return false.
            if (((object)t1 == null) || ((object)t2 == null))
            {
                return !false;
            }

            return(t1.CountType0 >= t2.CountType0 && t1.TimeType0 >= t2.TimeType0
                              && t1.CountType1 >= t2.CountType1 && t1.TimeType1 >= t2.TimeType1);
        }

        public Types()
        {
            
        }

        public Types GetCopy()
        {
            return new Types(this);
        }
        public override string ToString()
        {
            return $"[{CountType0}, {CountType1}]";
        }

        public void AddType(Types t)
        {
            this.CountType0 += t.CountType0;
            this.CountType1 += t.CountType1;
        }

        public void AddSeq(Types t1,Types t2)
        {
            TimeType0 += t1.TimeType0 + t2.TimeType0;
            TimeType1 += t1.TimeType1 + t2.TimeType1;

            CountType0 += Math.Max(t1.CountType0, t2.CountType0);
            CountType1 += Math.Max(t1.CountType1, t2.CountType1);
        }

        public void AddPar(Types t1, Types t2)
        {
            TimeType0 += Math.Max(t1.TimeType0, t2.TimeType0);
            TimeType1 += Math.Max(t1.TimeType1, t2.TimeType1);

            CountType0 += (t1.CountType0 + t2.CountType0);
            CountType1 += (t1.CountType1 + t2.CountType1);
        }
        public void AddType(int type)
        {
            if (type == 0)
            {
                CountType0 ++;
            }
            else
            {
                CountType1 ++;
            }
        }

        public void AddTime(int time)
        {
            if (CountType0 == 0)
            {
                TimeType1 = time;
            }
            else if (CountType1 == 0)
            {
                TimeType0 = time;
            }
            else
            {
                throw new Exception("Не знойдзено пустога тыпа");
            }
        }

       
    }
    public class Vertex
    {
        private string n;

        public string GetStringN()
        {
            return n;
        }
        public int N { get; set; }

        public int Type { get; set; }
        public int Time { get; set; }

        public bool IsParallel { get; set; } = false;

        public int TempIndex { get; set; } = -1;

        public Types GetTypes { get; set; } = new Types();
 
        public List<Vertex> ChildrenVertices { get; set;}   = new List<Vertex>();

        public List<Vertex> FusionVertices { get; set; } = new List<Vertex>();

        public Vertex(int n, int type, int time)
        {
            this.N = n;
            this.Time = time;
            this.Type = type;

            GetTypes.AddType(type);
            GetTypes.AddTime(time);

        }

        public Vertex()
        {
            
        }

        public int InputCount { get; set; }

        public int HasRef { get; set; }

        public Vertex(int n, int inpc)
        {
            this.N = n;
            this.InputCount = inpc;
        }


        public Vertex(int[] arr)
        {

            GetTypes.CountType0 = arr[0];
            GetTypes.CountType1 = arr[1];


        }
        public List<Vertex> Parall = new List<Vertex>();

        public void AddSeq(Vertex a, Vertex b)
        {
            GetTypes.AddSeq(a.GetTypes,b.GetTypes);
            this.n += a.N +""+ b.N;
            this.FusionVertices.Add(a);
            this.FusionVertices.Add(b);
            this.ChildrenVertices.AddRange(a.ChildrenVertices);
            this.ChildrenVertices.AddRange(b.ChildrenVertices.Except(ChildrenVertices));
        }

        public int Level { get; set; } = -1;

        public void AddPar(Vertex a, Vertex b)
        {
            GetTypes.AddPar(a.GetTypes, b.GetTypes);
            this.n += $"{(a.N == 0 ? a.n : a.N.ToString())} \\ {(b.N == 0 ? b.n : b.N.ToString())}";
            a.IsParallel = true;
            b.IsParallel = true;
            IsParallel = true;
            this.FusionVertices.Add(a);
            this.FusionVertices.Add(b);
            this.ChildrenVertices.AddRange(a.ChildrenVertices);
            this.ChildrenVertices.AddRange(b.ChildrenVertices.Except(ChildrenVertices));
        }
        public bool IsEmpty => ChildrenVertices.Count == 0;

        public string GetChildrenText()
        {
            return ChildrenVertices.Aggregate("", (current, c) => current + (c.N == 0 ? c.n : c.N.ToString() + " "));
        }

        public override string ToString()
        {
            return $" {(N==0?n:"N = "+N.ToString())}, {GetTypes} {(GetChildrenText().Length==0?"":" ,CH = ")+GetChildrenText()}\n";
        }
    }

}