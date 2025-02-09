using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Xazane.DataLayer.Repo
{
    public class MultipleReport : IMultipleReport
    {

        #region Items
        public Tuple<T1, T2>                    Multiple<T1, T2>                    (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            T1 Item1; 
            T2 Item2;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t           = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance    = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr      = instance.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr      += WhereClauseAppend;

                using (var con  = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr,Params))
                    {
                       Item1    = multi.Read<T1>().SingleOrDefault();
                       Item2    = multi.Read<T2>().SingleOrDefault();
                    }
                }
            }
            else
            {
                var t1          = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1   = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1     = instance1.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1     += WhereClauseAppend;
                //===============================
                var t2          = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2   = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2     = instance2.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2     += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    Item1       = con.QueryFirstOrDefault<T1>(SqlStr1, Params);
                    Item2       = con.QueryFirstOrDefault<T2>(SqlStr2, Params);
                }
            }
            return new Tuple<T1, T2>(Item1, Item2);
        }
        public Tuple<T1, T2, T3>                Multiple<T1, T2, T3>                (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            T1 Item1;
            T2 Item2;
            T3 Item3;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>().SingleOrDefault();
                        Item2 = multi.Read<T2>().SingleOrDefault();
                        Item3 = multi.Read<T3>().SingleOrDefault();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;

                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.QueryFirstOrDefault<T1>(SqlStr1, Params);
                    Item2 = con.QueryFirstOrDefault<T2>(SqlStr2, Params);
                    Item3 = con.QueryFirstOrDefault<T3>(SqlStr3, Params);
                }
            }
            return new Tuple<T1, T2, T3>(Item1, Item2, Item3);
        }
        public Tuple<T1, T2, T3, T4>            Multiple<T1, T2, T3, T4>            (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            T1 Item1;
            T2 Item2;
            T3 Item3;
            T4 Item4;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>().SingleOrDefault();
                        Item2 = multi.Read<T2>().SingleOrDefault();
                        Item3 = multi.Read<T3>().SingleOrDefault();
                        Item4 = multi.Read<T4>().SingleOrDefault();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;

                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;

                //===============================
                var t4 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T4>));
                var instance4 = (DapperEntityConfiguration<T4>)Activator.CreateInstance(t4);
                var SqlStr4 = instance4.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr4 += WhereClauseAppend;
                //===============================

                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.QueryFirstOrDefault<T1>(SqlStr1, Params);
                    Item2 = con.QueryFirstOrDefault<T2>(SqlStr2, Params);
                    Item3 = con.QueryFirstOrDefault<T3>(SqlStr3, Params);
                    Item4 = con.QueryFirstOrDefault<T4>(SqlStr4, Params);
                }
            }
            return new Tuple<T1, T2, T3, T4>(Item1, Item2, Item3, Item4);
        }
        public Tuple<T1, T2, T3, T4, T5>        Multiple<T1, T2, T3, T4, T5>        (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            T1 Item1;
            T2 Item2;
            T3 Item3;
            T4 Item4;
            T5 Item5;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>().SingleOrDefault();
                        Item2 = multi.Read<T2>().SingleOrDefault();
                        Item3 = multi.Read<T3>().SingleOrDefault();
                        Item4 = multi.Read<T4>().SingleOrDefault();
                        Item5 = multi.Read<T5>().SingleOrDefault();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;

                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;

                //===============================
                var t4 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T4>));
                var instance4 = (DapperEntityConfiguration<T4>)Activator.CreateInstance(t4);
                var SqlStr4 = instance4.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr4 += WhereClauseAppend;
                
                //===============================
                var t5 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T5>));
                var instance5 = (DapperEntityConfiguration<T5>)Activator.CreateInstance(t5);
                var SqlStr5 = instance5.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr5 += WhereClauseAppend;
                //===============================

                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.QueryFirstOrDefault<T1>(SqlStr1, Params);
                    Item2 = con.QueryFirstOrDefault<T2>(SqlStr2, Params);
                    Item3 = con.QueryFirstOrDefault<T3>(SqlStr3, Params);
                    Item4 = con.QueryFirstOrDefault<T4>(SqlStr4, Params);
                    Item5 = con.QueryFirstOrDefault<T5>(SqlStr5, Params);
                }
            }
            return new Tuple<T1, T2, T3, T4, T5 >(Item1, Item2, Item3, Item4, Item5);
        }
        public Tuple<T1, T2, T3, T4, T5, T6>    Multiple<T1, T2, T3, T4, T5, T6>    (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            T1 Item1;
            T2 Item2;
            T3 Item3;
            T4 Item4;
            T5 Item5;
            T6 Item6;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>().SingleOrDefault();
                        Item2 = multi.Read<T2>().SingleOrDefault();
                        Item3 = multi.Read<T3>().SingleOrDefault();
                        Item4 = multi.Read<T4>().SingleOrDefault();
                        Item5 = multi.Read<T5>().SingleOrDefault();
                        Item6 = multi.Read<T6>().SingleOrDefault();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;

                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;

                //===============================
                var t4 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T4>));
                var instance4 = (DapperEntityConfiguration<T4>)Activator.CreateInstance(t4);
                var SqlStr4 = instance4.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr4 += WhereClauseAppend;

                //===============================
                var t5 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T5>));
                var instance5 = (DapperEntityConfiguration<T5>)Activator.CreateInstance(t5);
                var SqlStr5 = instance5.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr5 += WhereClauseAppend;
                
                //===============================
                var t6 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T6>));
                var instance6 = (DapperEntityConfiguration<T6>)Activator.CreateInstance(t6);
                var SqlStr6 = instance6.GetItem;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr6 += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.QueryFirstOrDefault<T1>(SqlStr1, Params);
                    Item2 = con.QueryFirstOrDefault<T2>(SqlStr2, Params);
                    Item3 = con.QueryFirstOrDefault<T3>(SqlStr3, Params);
                    Item4 = con.QueryFirstOrDefault<T4>(SqlStr4, Params);
                    Item5 = con.QueryFirstOrDefault<T5>(SqlStr5, Params);
                    Item6 = con.QueryFirstOrDefault<T6>(SqlStr6, Params);
                }
            }
            return new Tuple<T1, T2, T3, T4, T5, T6>(Item1, Item2, Item3, Item4, Item5,Item6);
        }
        #endregion
        #region Lists
        public Tuple<IEnumerable<T1>, IEnumerable<T2>>                                                                      MultipleList<T1, T2>                    (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            IEnumerable<T1> Item1;
            IEnumerable<T2> Item2;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>();
                        Item2 = multi.Read<T2>();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.Query<T1>(SqlStr1, Params);
                    Item2 = con.Query<T2>(SqlStr2, Params);
                }
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(Item1, Item2);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>>                                                     MultipleList<T1, T2, T3>                (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            IEnumerable<T1> Item1;
            IEnumerable<T2> Item2;
            IEnumerable<T3> Item3;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>();
                        Item2 = multi.Read<T2>();
                        Item3 = multi.Read<T3>();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;
                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;
               
                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.Query<T1>(SqlStr1, Params);
                    Item2 = con.Query<T2>(SqlStr2, Params);
                    Item3 = con.Query<T3>(SqlStr3, Params);
                }
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>>(Item1, Item2,Item3);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>>                                    MultipleList<T1, T2, T3, T4>            (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            IEnumerable<T1> Item1;
            IEnumerable<T2> Item2;
            IEnumerable<T3> Item3;
            IEnumerable<T4> Item4;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>();
                        Item2 = multi.Read<T2>();
                        Item3 = multi.Read<T3>();
                        Item4 = multi.Read<T4>();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;
                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;
                //===============================
                var t4 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T4>));
                var instance4 = (DapperEntityConfiguration<T4>)Activator.CreateInstance(t4);
                var SqlStr4 = instance4.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr4 += WhereClauseAppend;
                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.Query<T1>(SqlStr1, Params);
                    Item2 = con.Query<T2>(SqlStr2, Params);
                    Item3 = con.Query<T3>(SqlStr3, Params);
                    Item4 = con.Query<T4>(SqlStr4, Params);
                }
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>>(Item1, Item2, Item3, Item4);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>>                   MultipleList<T1, T2, T3, T4, T5>        (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            IEnumerable<T1> Item1;
            IEnumerable<T2> Item2;
            IEnumerable<T3> Item3;
            IEnumerable<T4> Item4;
            IEnumerable<T5> Item5;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>();
                        Item2 = multi.Read<T2>();
                        Item3 = multi.Read<T3>();
                        Item4 = multi.Read<T4>();
                        Item5 = multi.Read<T5>();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;
                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;
                //===============================
                var t4 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T4>));
                var instance4 = (DapperEntityConfiguration<T4>)Activator.CreateInstance(t4);
                var SqlStr4 = instance4.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr4 += WhereClauseAppend;
                //===============================
                var t5 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T5>));
                var instance5 = (DapperEntityConfiguration<T5>)Activator.CreateInstance(t5);
                var SqlStr5 = instance5.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr5 += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.Query<T1>(SqlStr1, Params);
                    Item2 = con.Query<T2>(SqlStr2, Params);
                    Item3 = con.Query<T3>(SqlStr3, Params);
                    Item4 = con.Query<T4>(SqlStr4, Params);
                    Item5 = con.Query<T5>(SqlStr5, Params);
                }
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>>(Item1, Item2, Item3, Item4,Item5);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>>  MultipleList<T1, T2, T3, T4, T5, T6>    (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            IEnumerable<T1> Item1;
            IEnumerable<T2> Item2;
            IEnumerable<T3> Item3;
            IEnumerable<T4> Item4;
            IEnumerable<T5> Item5;
            IEnumerable<T6> Item6;

            var asm = Assembly.Load(this.GetType().Assembly.GetName());

            if (FetchSQL == Enums.NzMultipleReportKind.First)
            {
                var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t);
                var SqlStr = instance.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    using (var multi = con.QueryMultiple(SqlStr, Params))
                    {
                        Item1 = multi.Read<T1>();
                        Item2 = multi.Read<T2>();
                        Item3 = multi.Read<T3>();
                        Item4 = multi.Read<T4>();
                        Item5 = multi.Read<T5>();
                        Item6 = multi.Read<T6>();
                    }
                }
            }
            else
            {
                var t1 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T1>));
                var instance1 = (DapperEntityConfiguration<T1>)Activator.CreateInstance(t1);
                var SqlStr1 = instance1.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr1 += WhereClauseAppend;
                //===============================
                var t2 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T2>));
                var instance2 = (DapperEntityConfiguration<T2>)Activator.CreateInstance(t2);
                var SqlStr2 = instance2.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr2 += WhereClauseAppend;
                //===============================
                var t3 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T3>));
                var instance3 = (DapperEntityConfiguration<T3>)Activator.CreateInstance(t3);
                var SqlStr3 = instance3.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr3 += WhereClauseAppend;
                //===============================
                var t4 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T4>));
                var instance4 = (DapperEntityConfiguration<T4>)Activator.CreateInstance(t4);
                var SqlStr4 = instance4.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr4 += WhereClauseAppend;
                //===============================
                var t5 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T5>));
                var instance5 = (DapperEntityConfiguration<T5>)Activator.CreateInstance(t5);
                var SqlStr5 = instance5.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr5 += WhereClauseAppend;

                //===============================
                var t6 = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T6>));
                var instance6 = (DapperEntityConfiguration<T5>)Activator.CreateInstance(t6);
                var SqlStr6 = instance6.GetList;

                if (!string.IsNullOrEmpty(WhereClauseAppend))
                    SqlStr6 += WhereClauseAppend;

                using (var con = ConnectionManager.Create())
                {
                    Item1 = con.Query<T1>(SqlStr1, Params);
                    Item2 = con.Query<T2>(SqlStr2, Params);
                    Item3 = con.Query<T3>(SqlStr3, Params);
                    Item4 = con.Query<T4>(SqlStr4, Params);
                    Item5 = con.Query<T5>(SqlStr5, Params);
                    Item6 = con.Query<T6>(SqlStr6, Params);
                }
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>>(Item1, Item2, Item3, Item4, Item5,Item6);
        }
        #endregion
    }
}
