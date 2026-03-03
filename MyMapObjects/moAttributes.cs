using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMapObjects
{
    /// <summary>
    /// 属性表封装
    /// </summary>
    public class moAttributes
    {
        #region 字段

        private List<object> _Attributes;

        #endregion

        #region 构造函数

        public moAttributes()
        {
            _Attributes = new List<object>();
        }
        public Int32 Count
        {
            get { return _Attributes.Count; }
        }
        #endregion


        #region 方法
        /// <summary>
        /// 获取指定索引处的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object GetItem(Int32 index)
        {
            return _Attributes[index];
        }
        /// <summary>
        /// 设置指定索引处的元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetItem(Int32 index, object value)
        {
            _Attributes[index] = value;
        }
        /// <summary>
        /// 转换为数组形式返回
        /// </summary>
        /// <returns></returns>
        public object[] ToArray()
        {
            return _Attributes.ToArray();
        }
        /// <summary>
        /// 从指定数组中获取元素
        /// </summary>
        /// <param name="values"></param>
        public void FromArray(object[] values)
        {
            _Attributes.Clear();
            _Attributes.AddRange(values);
        }
        /// <summary>
        /// 在末尾添加一个值
        /// </summary>
        /// <param name="value"></param>
        public void Append(object value)
        {
            _Attributes.Add(value);
        }
        /// <summary>
        /// 删除指定索引处的元素
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(Int32 index)
        {
            _Attributes.RemoveAt(index);
        }
        /// <summary>
        /// 克隆一个对象
        /// </summary>
        /// <returns></returns>
        public moAttributes Clone()
        {
            moAttributes sAttributes = new moAttributes();
            sAttributes._Attributes.AddRange(this._Attributes);//值类型就可以这样将本对象this的成员赋给，但是对象类型的话不能this，对象类型的this返回一个引用而不是克隆
            return sAttributes;
        }

        #endregion

    }
}
