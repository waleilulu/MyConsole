﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//業務員類別 繼承父親Employees
namespace MyConsole.Models
{
    //繼承父親Employees
    public class Sales: Employees //Sales繼承父類別Employees，在 C# 中，繼承使用的是冒號 (:)，而不是 extends（這是 Java 中的語法）
	{
        //資料欄位 Data Field
        private Int32 _salesAmount; //業績
        private Int32 _commission; //佣金，唯讀屬性

        // 自訂建構子且明確指向父親建構子: base(...) 指向父親特定建構子
        public Sales(Int32 id, String name, String address, Int32 salesAmount): base(id, name, address) 
        {
            _salesAmount = salesAmount; //目標業績
        }


        //精靈產生出來的，使用lambda進行屬性的實作
        public int SalesAmount { get => _salesAmount; set => _salesAmount = value; } //業績需要經過計算
        public int Commission { get => _commission; } //佣金部分是唯讀屬性，只能查詢不能設定
    }
}