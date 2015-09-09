// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ItemSaleHistoryJson.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using st=Starcounter.Templates;
using s=Starcounter;
using _GEN1_=System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_=System.CodeDom.Compiler.GeneratedCodeAttribute;
using _ScTemplate_=Starcounter.Templates.Template;
#pragma warning disable 0108
#pragma warning disable 1591

using __IItSALE_QTY__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_QTY;
using __ItemSale1__ = global::ItemSaleHistoryJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ItemSaleHistoryJson.ItemSaleHistoryElementJson>;
using __IItBILL_DAT__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.BILL_DATED;
using __IItCUSTOMER__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.CUSTOMERS_NAME;
using __IItSALE_SUB__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_SUBTOTAL;
using __IItSALE_UNI__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_UNITPRICE;
using __IItSALE_T_Q__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_T_QUANTITY;
using __IItSALE_PCS__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_PCS_CTN;
using __IItSALE_ITE1__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_ITEM_NAME;
using __IItSALE_ITE__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_ITEM_CODE;
using __IItSALE_BIL__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_BILL_ID;
using __Arr__ = global::Starcounter.Arr<global::ItemSaleHistoryJson.ItemSaleHistoryElementJson>;
using __ItemSale2__ = global::ItemSaleHistoryJson.Input;
using __ItItemSale2__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input;
using __ItItemSale1__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __IItSchema__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.JsonByExample.Schema;
using __ItItemSale__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson;
using __ItSchema__ = global::ItemSaleHistoryJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ItemSale__ = global::ItemSaleHistoryJson;
using __IItSALE_ID__ = global::ItemSaleHistoryJson.ItemSaleHistoryElementJson.Input.SALE_ID;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ItemSaleHistoryJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ItSchema__ DefaultTemplate = new __ItSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemSaleHistoryJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemSaleHistoryJson(__ItSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ItSchema__ Template { get { return (__ItSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__ItemSaleHistory__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ItemSale__);
                ClassName = "ItemSaleHistoryJson";
                Properties.ClearExposed();
                ItemSaleHistory = Add<__TArray__>("ItemSaleHistory");
                ItemSaleHistory.SetCustomGetElementType((arr) => { return __ItItemSale__.DefaultTemplate;});
                ItemSaleHistory.SetCustomAccessors((_p_) => { return ((__ItemSale__)_p_).__bf__ItemSaleHistory__; }, (_p_, _v_) => { ((__ItemSale__)_p_).__bf__ItemSaleHistory__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ItemSale__(this) { Parent = parent }; }
            public __TArray__ ItemSaleHistory;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ ItemSaleHistory {
#line 17 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.ItemSaleHistory.Getter(this); }
#line 17 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.ItemSaleHistory.Setter(this, value); } }
#line default

    
    #line hidden
    public class ItemSaleHistoryElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __IItSchema__ DefaultTemplate = new __IItSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemSaleHistoryElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemSaleHistoryElementJson(__IItSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __IItSchema__ Template { get { return (__IItSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__SALE_ID__;
        private System.Int64 __bf__SALE_QTY__;
        private System.Int64 __bf__SALE_BILL_ID__;
        private System.String __bf__SALE_ITEM_CODE__;
        private System.String __bf__SALE_ITEM_NAME__;
        private System.Int64 __bf__SALE_PCS_CTN__;
        private System.Int64 __bf__SALE_T_QUANTITY__;
        private System.Int64 __bf__SALE_UNITPRICE__;
        private System.Int64 __bf__SALE_SUBTOTAL__;
        private System.String __bf__CUSTOMERS_NAME__;
        private System.String __bf__BILL_DATED__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ItItemSale__);
                    ClassName = "ItemSaleHistoryElementJson";
                    Properties.ClearExposed();
                    SALE_ID = Add<__TLong__>("SALE_ID");
                    SALE_ID.DefaultValue = 0L;
                    SALE_ID.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_ID__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_ID__ = (System.Int64)_v_; }, false);
                    SALE_QTY = Add<__TLong__>("SALE_QTY");
                    SALE_QTY.DefaultValue = 0L;
                    SALE_QTY.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_QTY__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_QTY__ = (System.Int64)_v_; }, false);
                    SALE_BILL_ID = Add<__TLong__>("SALE_BILL_ID");
                    SALE_BILL_ID.DefaultValue = 0L;
                    SALE_BILL_ID.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_BILL_ID__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_BILL_ID__ = (System.Int64)_v_; }, false);
                    SALE_ITEM_CODE = Add<__TString__>("SALE_ITEM_CODE");
                    SALE_ITEM_CODE.DefaultValue = "";
                    SALE_ITEM_CODE.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_ITEM_CODE__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_ITEM_CODE__ = (System.String)_v_; }, false);
                    SALE_ITEM_NAME = Add<__TString__>("SALE_ITEM_NAME");
                    SALE_ITEM_NAME.DefaultValue = "";
                    SALE_ITEM_NAME.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_ITEM_NAME__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_ITEM_NAME__ = (System.String)_v_; }, false);
                    SALE_PCS_CTN = Add<__TLong__>("SALE_PCS_CTN");
                    SALE_PCS_CTN.DefaultValue = 0L;
                    SALE_PCS_CTN.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_PCS_CTN__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_PCS_CTN__ = (System.Int64)_v_; }, false);
                    SALE_T_QUANTITY = Add<__TLong__>("SALE_T_QUANTITY");
                    SALE_T_QUANTITY.DefaultValue = 0L;
                    SALE_T_QUANTITY.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_T_QUANTITY__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_T_QUANTITY__ = (System.Int64)_v_; }, false);
                    SALE_UNITPRICE = Add<__TLong__>("SALE_UNITPRICE");
                    SALE_UNITPRICE.DefaultValue = 0L;
                    SALE_UNITPRICE.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_UNITPRICE__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_UNITPRICE__ = (System.Int64)_v_; }, false);
                    SALE_SUBTOTAL = Add<__TLong__>("SALE_SUBTOTAL");
                    SALE_SUBTOTAL.DefaultValue = 0L;
                    SALE_SUBTOTAL.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SALE_SUBTOTAL__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SALE_SUBTOTAL__ = (System.Int64)_v_; }, false);
                    CUSTOMERS_NAME = Add<__TString__>("CUSTOMERS_NAME");
                    CUSTOMERS_NAME.DefaultValue = "";
                    CUSTOMERS_NAME.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__CUSTOMERS_NAME__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__CUSTOMERS_NAME__ = (System.String)_v_; }, false);
                    BILL_DATED = Add<__TString__>("BILL_DATED");
                    BILL_DATED.DefaultValue = "";
                    BILL_DATED.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__BILL_DATED__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__BILL_DATED__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ItItemSale__(this) { Parent = parent }; }
                public __TLong__ SALE_ID;
                public __TLong__ SALE_QTY;
                public __TLong__ SALE_BILL_ID;
                public __TString__ SALE_ITEM_CODE;
                public __TString__ SALE_ITEM_NAME;
                public __TLong__ SALE_PCS_CTN;
                public __TLong__ SALE_T_QUANTITY;
                public __TLong__ SALE_UNITPRICE;
                public __TLong__ SALE_SUBTOTAL;
                public __TString__ CUSTOMERS_NAME;
                public __TString__ BILL_DATED;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SALE_ID {
#line 4 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_ID.Getter(this); }
#line 4 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SALE_QTY {
#line 5 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_QTY.Getter(this); }
#line 5 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_QTY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SALE_BILL_ID {
#line 6 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_BILL_ID.Getter(this); }
#line 6 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_BILL_ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SALE_ITEM_CODE {
#line 7 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_ITEM_CODE.Getter(this); }
#line 7 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_ITEM_CODE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SALE_ITEM_NAME {
#line 8 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_ITEM_NAME.Getter(this); }
#line 8 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_ITEM_NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SALE_PCS_CTN {
#line 9 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_PCS_CTN.Getter(this); }
#line 9 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_PCS_CTN.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SALE_T_QUANTITY {
#line 10 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_T_QUANTITY.Getter(this); }
#line 10 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SALE_UNITPRICE {
#line 11 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_UNITPRICE.Getter(this); }
#line 11 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_UNITPRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SALE_SUBTOTAL {
#line 12 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.SALE_SUBTOTAL.Getter(this); }
#line 12 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.SALE_SUBTOTAL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CUSTOMERS_NAME {
#line 13 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.CUSTOMERS_NAME.Getter(this); }
#line 13 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.CUSTOMERS_NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String BILL_DATED {
#line 15 "Server\Partials\ItemSaleHistoryJson.json"
    get {
#line hidden
        return Template.BILL_DATED.Getter(this); }
#line 15 "Server\Partials\ItemSaleHistoryJson.json"
    set {
#line hidden
        Template.BILL_DATED.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class SALE_ID : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SALE_QTY : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SALE_BILL_ID : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SALE_ITEM_CODE : Input<__ItItemSale__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class SALE_ITEM_NAME : Input<__ItItemSale__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class SALE_PCS_CTN : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SALE_T_QUANTITY : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SALE_UNITPRICE : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SALE_SUBTOTAL : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class CUSTOMERS_NAME : Input<__ItItemSale__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class BILL_DATED : Input<__ItItemSale__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public static class Input {
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108