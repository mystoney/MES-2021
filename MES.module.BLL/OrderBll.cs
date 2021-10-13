using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MES.module.BLL
{
    public class OrderBll    
    {
        #region 老版本代码
        /// <summary>
        /// 老版本-新建工单
        /// </summary>
        /// <param name="Order_No"></param>
        /// <param name="SchemeNo"></param>
        /// <param name="Order_qty"></param>
        /// <returns></returns>
        public int SaveOrder(string Order_No, string SchemeNo, int Order_qty)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            int i = 0;
            od.NewOrder(Order_No, SchemeNo, Order_qty);
            i = 1;
            return i;
        }


        /// <summary>
        /// 老版本-NewOrder
        /// </summary>
        /// <param name="StageProduct"></param>
        /// <returns></returns>
        public DataTable GetOrderList(int StageProduct)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            DataTable dt = new DataTable();
            dt=od.GetOrderList(StageProduct);
            return dt;
        }

        /// <summary>
        /// 老版本-NewOrder
        /// </summary>
        /// <param name="Order_No"></param>
        /// <returns></returns>
        public bool OrderBeAllowed(string Order_No)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            bool available = false;
            if (od.OrderNumberOfExisting(Order_No) == 0)
            {
                available = true;
            }
            return available;
        }
        #endregion



        #region 保存ZYQ提供的工单信息
        public int SaveOrderZYQ(DataTable dt)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            return od.SaveOrderZYQ(dt);
        }
        #endregion

        #region  新版-加载订单-ZYQ
        /// <summary>
        /// 加载订单
        /// </summary>
        /// <param name="StageProduct">1测试订单 =0正式订单</param>
        /// <returns></returns>
        public DataTable nMES_GetOrderList_ZYQ(int customer_state)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            DataTable dt = od.nMES_GetOrderList_ZYQ(customer_state);
            return dt;
        }
        #endregion

        #region  新版-加载订单-MES
        /// <summary>
        /// 加载订单
        /// </summary>
        /// <param name="StageProduct">1测试订单 =0正式订单</param>
        /// <returns></returns>
        public DataTable nMES_GetOrderList_MES(int customer_state)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            DataTable dt = od.nMES_GetOrderList_MES(customer_state);
            return dt;
        }
        #endregion

        #region 新版-加载工单选项OrderItemOptionZYQ
        /// <summary>
        /// 接收到的订单选项表
        /// </summary>
        public class OrderItemOptionZYQ
        {
            public string Item_No { get; set; }
            public string Option_No { get; set; }
            public string Item_Name { get; set; }
            public string Option_Name { get; set; }
        }



        /// <summary>
        /// 返回信息的类
        /// </summary>
        public class Return_Message
        {
            /// <summary>
            /// 构造函数
            /// </summary>
            public Return_Message()
            {
            }


            /// <summary>
            /// 返回的状态
            /// </summary>
            public Return_State State { get; set; }

            /// <summary>
            /// 返回的值的JSON对象
            /// </summary>
            public string Return_Value { get; set; }
            /// <summary>
            /// 返回的信息
            /// </summary>
            public string Message { get; set; }

            /// <summary>
            /// 返回信息类中信息状态用的枚举
            /// </summary>
            public enum Return_State
            {
                /// <summary>
                /// OK
                /// </summary>
                OK = 1,
                /// <summary>
                /// Error
                /// </summary>
                Error = 2
            }

        }
        #endregion

        #region 更新OpListNo，UPS_prun，SchemeNo，Combination_no,GetProductList
        /// <summary>
        /// 更新OpListNo，UPS_prun，SchemeNo，Combination_no
        /// </summary>
        /// <param name="字段名">要更改的字段</param>
        /// <param name="字段值">值</param>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">行号</param>
        /// <returns></returns>
        public int UpdateOrderInfo(string 字段名, int 字段值, string job_num, int suffix)
        {
            try
            {
                DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
                return od.UpdateOrderInfo(字段名, 字段值, job_num, suffix);
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }
        #endregion

        #region 更新nMES_Order_detail_ProductList，PushState_CAOBO，PushState_JINGYUAN
        /// <summary>
        /// 更新nMES_Order_detail_ProductList，PushState_CAOBO，PushState_JINGYUAN
        /// </summary>
        /// <param name="id">产品清单行id</param>
        /// <returns>1成功 0不成功</returns>
        public int UpdateProductListInfo(string 字段名,int 字段值, int id)
        {
            try
            {
                DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
                return od.UpdateProductListInfo(字段名, 字段值, id);
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }
        #endregion

        #region 新版-保存工单-主表-款号数量等
        /// <summary>
        /// 新版-保存订单信息-主表
        /// </summary>
        /// <param name="OrderMasterList">订单信息</param>
        /// <returns>0不成功 1成功</returns>
        public int SaveOrderMaster(OrderBll.SelectOrderInfo OrderInfo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("job_num");
            dt.Columns.Add("suffix");
            dt.Columns.Add("style_no");
            dt.Columns.Add("style_des");
            dt.Columns.Add("Combination_no");
            dt.Columns.Add("job_qty");
            dt.Columns.Add("manhour");
            dt.Columns.Add("memo_no");
            dt.Columns.Add("memo_name");
            dt.Columns.Add("customer_state");
            dt.Columns.Add("customer_state_des");
            DataRow dr = dt.NewRow();
            dr["job_num"] = OrderInfo.job_num;
            dr["suffix"] = OrderInfo.suffix;
            dr["Style_no"] = OrderInfo.Style_no;
            dr["style_des"] = OrderInfo.style_des;
            dr["Combination_no"] = OrderInfo.Combination_no;
            dr["job_qty"] = OrderInfo.job_qty;
            dr["manhour"] = OrderInfo.manhour;
            dr["memo_no"] = OrderInfo.memo_no;
            dr["memo_name"] = OrderInfo.memo_name;
            dr["customer_state"] = OrderInfo.customer_state;
            dr["customer_state_des"] = OrderInfo.customer_state_des;
            dt.Rows.Add(dr);

            int i = 0;
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();            
            try
            {
                return i = od.SaveOrderMaster(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 新版-保存工单-主表-款号选项
        /// <summary>
        /// 新版-保存订单信息-选项
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <param name="OpListNo">工序清单号</param>
        /// <returns>0不成功 1成功 2已存在</returns>
        public int SaveOrderOptionList(string job_num, int suffix, List<string> lst)
        {
            int i = 0;
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            try
            {
                return i = od.SaveOrderOptionList(job_num, suffix, lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 新版-保存工单-子表-产品编码明细（按单件推送）
        /// <summary>
        /// 保存工单-子表-产品编码明细（按单件推送）
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <param name="dt">产品编码明细</param>
        /// <returns></returns>
        public int SaveProductList(string job_num, int suffix, DataTable dt)
        {
            int i = 0;
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            try
            {
                return i = od.SaveProductList(job_num, suffix, dt);            
             }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 新版-保存工单-工序清单
            /// <summary>
            /// 新版-保存订单信息-工序清单
            /// </summary>
            /// <param name="job_num">工单号</param>
            /// <param name="suffix">工单行号</param>
            /// <param name="SchemeNo">工序清单号</param>
            /// <returns>0不成功 1成功 2已存在</returns>
        public int SaveOrderSchemeList(string job_num, int suffix, int SchemeNo)
        {
            int i = 0;
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            try
            {
                return i = od.SaveOrderSchemeList(job_num, suffix, SchemeNo);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 新版-保存工单-方案
        /// <summary>
        ///  新版-保存工单-方案
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <param name="OpListNo">工序清单号</param>
        /// <returns>0不成功 1成功 2已存在</returns>
        public int SaveOrderOperationList(string job_num, int suffix, int OpListNo)
        {
            int i = 0;
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            try
            {               
                i = od.SaveOrderOperationList(job_num, suffix, OpListNo);
                if (i == 1) { return i= UpdateOrderInfo("OpListNo", OpListNo,job_num,suffix); }
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 工具-DataTable转实体类集合
        /// <summary>
        /// DataTable转实体类集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class DataTableToEntity<T> where T : new()
        {
            //            调用示例：

            //DataTable转成实体类集合示例：

            //List<Peak> peaks = new DataTableToEntity<Peak>().FillModel(peakDt);//Peak为实体类  peakDt为DataTable

            //            实体类转成DataTable示例：

            //string abifilePath = Application.StartupPath + "\\outFiles\\peak\\peak_111.json";
            //            List<Abifile> abifiles = new DataTableToEntity<Abifile>().ReadDataToModel(abifilePath);
            //            DataTable abifileDt = new DataTableToEntity<Abifile>().FillDataTable(abifiles);




            /// <summary>
            /// table转实体集合
            /// </summary>
            /// <param name="dt"></param>
            /// <returns></returns>
            public List<T> FillModel(DataTable dt)
            {
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                List<T> result = new List<T>();
                foreach (DataRow dr in dt.Rows)
                {
                    try
                    {
                        T res = new T();
                        for (int i = 0; i < dr.Table.Columns.Count; i++)
                        {
                            PropertyInfo propertyInfo = res.GetType().GetProperty(dr.Table.Columns[i].ColumnName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                            if (propertyInfo != null && dr[i] != DBNull.Value)
                            {
                                var value = dr[i];
                                switch (propertyInfo.PropertyType.FullName)
                                {
                                    case "System.Decimal":
                                        propertyInfo.SetValue(res, Convert.ToDecimal(value), null); break;
                                    case "System.String":
                                        propertyInfo.SetValue(res, value, null); break;
                                    case "System.Int32":
                                        propertyInfo.SetValue(res, Convert.ToInt32(value), null); break;
                                    default:
                                        propertyInfo.SetValue(res, value, null); break;
                                }
                            }
                        }
                        result.Add(res);
                    }
                    catch (Exception ex)
                    {
                       // CommonMethod.SaveText(dr.Table.TableName + "表id：" + dr[0] + "表第二项值：" + dr[1] + " 导出异常,异常信息：" + ex.Message + "\r\n", Application.StartupPath + "\\outFiles" + "\\ErrorLog.txt");
                        continue;
                    }

                }
                return result;
            }

            /// <summary>
            /// 读取json内容转成实体类集合
            /// </summary>
            /// <param name="path"></param>
            /// <returns></returns>
            public List<T> ReadDataToModel(string path)
            {
                StreamReader sr = new StreamReader(path);
                try
                {
                    string temp = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(temp);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    sr.Dispose();
                    sr.Close();
                }
            }

            /// <summary>
            /// 实体类集合转table
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>
            public DataTable FillDataTable(List<T> modelList)
            {
                if (modelList == null || modelList.Count == 0)
                    return null;
                DataTable dt = CreatTable(modelList[0]);
                foreach (T model in modelList)
                {
                    DataRow dr = dt.NewRow();
                    foreach (PropertyInfo p in typeof(T).GetProperties())
                    {
                        dr[p.Name] = p.GetValue(model, null);
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }

            /// <summary>
            /// 根据实体创建table
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>
            private DataTable CreatTable(T model)
            {
                DataTable dt = new DataTable(typeof(T).Name);
                foreach (PropertyInfo p in typeof(T).GetProperties())
                {
                    dt.Columns.Add(new DataColumn(p.Name, p.PropertyType));
                }
                return dt;
            }
        }
        #endregion

        #region 工单类SelectOrderInfo
        public class SelectOrderInfo
        {
            /// <summary>
            /// 工单号
            /// </summary>
            public string job_num { get; set; }
            /// <summary>
            /// 工单行号
            /// </summary>
            public int suffix { get; set; }
            /// <summary>
            /// 款号
            /// </summary>
            public string Style_no { get; set; }
            /// <summary>
            /// 款号描述
            /// </summary>
            public string style_des { get; set; }
            /// <summary>
            /// 工单数量
            /// </summary>
            public int job_qty { get; set; }
            /// <summary>
            /// 选项值
            /// </summary>
            public string memo_no { get; set; }
            /// <summary>
            /// 选项说明
            /// </summary>
            public string memo_name { get; set; }

            public int  customer_state { get; set; }

            public string customer_state_des {get; set; }
            
            /// <summary>
            /// 总工时
            /// </summary>
            public int manhour { get; set; }


            /// <summary>
            /// 生产路线号
            /// </summary>
            public int SchemeNo { get; set; }

            /// <summary>
            /// 工序清单号
            /// </summary>
            public int OpListNo { get; set; }



            /// <summary>
            /// 选项组合号
            /// </summary>
            public int Combination_no { get; set; }
            /// <summary>
            /// 产品清单
            /// </summary>
            public int GetProductList { get; set; }
        }
        #endregion

        #region JSON新版-给曹博推送工单对应的工序清单
        /// <summary>
        /// 给曹博推送工单对应的工序清单
        /// </summary>
        /// <param name="Order_no">工单号</param>
        /// <returns>Json</returns>
        public string GetJson_OperationList(int OpListNo)
        {
            DAL.OperationDal.OperationDAL od = new DAL.OperationDal.OperationDAL();
            string json = od.GetJson_OperationList(OpListNo);
            return json;
        }
        #endregion

        #region JSON新版-给敬元推送工单对应的生产路线
        /// <summary>
        /// 给敬元推送工单对应的生产路线
        /// </summary>
        /// <param name="Order_no">工单号</param>
        /// <returns>Json</returns>
        public string GetJson_Order_Scheme(string SchemeNo)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            string json = od.GetJson_Order_Scheme(SchemeNo);
            return json;
        }
        #endregion

        #region JSON新版-给敬元推送吊挂订单和ERP工单对应

        public string GetJson_Order_Eton(List<ProductUPS> productUPS)
        { 
            DataTable dt = ListProductUPsToDT(productUPS);
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            string json = od.GetJson_Order_Eton(dt);
            return json;
        }
        #endregion

        #region JSON新版-给吊挂推送吊挂工序和工单
        /// <summary>
        /// 推送到吊挂线-生成订单
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <returns>json语句</returns>
        public string ToETON_Order(string job_num, int suffix)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            string json = od.ToETON_Order(job_num, suffix);
            return json;
        }
        /// <summary>
        /// 推送到吊挂线-方案
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <returns>json语句</returns>
        public string ToETON_SchemeList(string job_num, int suffix)
        {
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            string json = od.ToETON_SchemeList(job_num, suffix);
            return json;
        }
        #endregion

        #region 新版-获取到当前工单未推送至吊挂系统的产品清单
        /// <summary>
        /// 获取到当前工单未推送至吊挂系统的产品清单
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <returns></returns>
        public List<int> GetProductListNOTEton(string job_num, int suffix)
        {
            List<int> L_ProductCode = new List<int>();

            DAL.OrderDal.OrderDal ob = new DAL.OrderDal.OrderDal();
            L_ProductCode = ob.GetProductListNOTEton(job_num, suffix);
            return L_ProductCode;
        }
        #endregion

        #region 新版-获取到当前工单的产品清单-ALL-List
        /// <summary>
        /// 获取到当前工单的产品清单-ALL
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <returns></returns>
        public List<ProductUPS> GetProductList(string job_num, int suffix)
        {
            List<ProductUPS> L_ProductCode = new List<ProductUPS>();

            DAL.OrderDal.OrderDal ob = new DAL.OrderDal.OrderDal();
            DataTable dt = ob.GetProductList(job_num, suffix);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                    ProductUPS p = new ProductUPS();
                    p.id = Convert.ToInt32(dt.Rows[k]["id"].ToString().Trim());
                    p.ProductCode = dt.Rows[k]["ProductCode"].ToString().Trim();
                    p.UPS_prun = Convert.ToInt32(dt.Rows[k]["UPS_prun"].ToString().Trim());
                    L_ProductCode.Add(p);
            }
            return L_ProductCode;
        }
        #endregion

        #region 新版-获取到当前工单的产品清单-ALL-DataTable
        /// <summary>
        /// 获取到当前工单的产品清单-ALL
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <returns></returns>
        public DataTable GetProductListDT(string job_num, int suffix)
        {
            List<ProductUPS> L_ProductCode = new List<ProductUPS>();

            DAL.OrderDal.OrderDal ob = new DAL.OrderDal.OrderDal();
            DataTable dt = ob.GetProductList(job_num, suffix);            
            return dt;
        }
        #endregion

        #region 新版-获取到当前工单的产品清单-未成功推送给敬元的
        /// <summary>
        /// 获取到当前工单的产品清单-未成功推送给敬元的
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <returns></returns>
        public List<ProductUPS> GetProductList_NOTJINGYUAN(string job_num, int suffix)
        {
            List<ProductUPS> L_ProductCode = new List<ProductUPS>();

            DAL.OrderDal.OrderDal ob = new DAL.OrderDal.OrderDal();
            DataTable dt = ob.GetProductList_NoJINGYUAN(job_num, suffix);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                    ProductUPS p = new ProductUPS();
                    p.id = Convert.ToInt32(dt.Rows[k]["id"].ToString().Trim());
                    p.ProductCode = dt.Rows[k]["ProductCode"].ToString().Trim();
                    p.UPS_prun = Convert.ToInt32(dt.Rows[k]["UPS_prun"].ToString().Trim());
                    L_ProductCode.Add(p);
            }
            return L_ProductCode;
        }
        #endregion

        #region 新版-获取到当前工单的产品清单-未成功推送给曹博的
        /// <summary>
        /// 获取到当前工单的产品清单-未成功推送给曹博的
        /// </summary>
        /// <param name="job_num">工单号</param>
        /// <param name="suffix">工单行号</param>
        /// <returns></returns>
        public List<ProductUPS> GetProductList_NOTCAOBO(string job_num, int suffix)
        {
            List<ProductUPS> L_ProductCode = new List<ProductUPS>();

            DAL.OrderDal.OrderDal ob = new DAL.OrderDal.OrderDal();
            DataTable dt = ob.GetProductList_NoCAOBO(job_num, suffix);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                ProductUPS p = new ProductUPS();
                p.id = Convert.ToInt32(dt.Rows[k]["id"].ToString().Trim());
                p.ProductCode = dt.Rows[k]["ProductCode"].ToString().Trim();
                p.UPS_prun = Convert.ToInt32(dt.Rows[k]["UPS_prun"].ToString().Trim());
                L_ProductCode.Add(p);
            }
            return L_ProductCode;
        }
        #endregion

        #region 新版-保存吊挂订单号
        /// <summary>
        /// 保存吊挂订单号
        /// </summary>
        /// <param name="id">产品id</param>
        /// <param name="UPS_prun">吊挂订单</param>
        /// <returns></returns>
        public int SaveUPS_purn(int id, int UPS_prun)
        {
            int i = 0;
            DAL.OrderDal.OrderDal od = new DAL.OrderDal.OrderDal();
            return i = od.SaveUPS_purn(id, UPS_prun);        
        }
        #endregion

        #region 新版-将Product DataTable转为类
        /// <summary>
        /// 将Product DataTable转为类
        /// </summary>
        /// <param name="productUPS">DataTable</param>
        /// <returns></returns>
        public DataTable ListProductUPsToDT(List<ProductUPS> productUPS)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductCode");
            dt.Columns.Add("UPS_prun");
            for (int k = 0; k < productUPS.Count; k++)
            {
                DataRow dr = dt.NewRow();
                dr["ProductCode"] = productUPS[k].ProductCode;
                dr["UPS_prun"] = productUPS[k].UPS_prun;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public class ProductUPS
        {
            public int id { get; set; }
            public string ProductCode { get; set; }
            public int UPS_prun { get; set; }
        }
        #endregion

    }
}
