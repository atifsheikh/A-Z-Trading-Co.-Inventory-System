// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ItemSaleHistoryJson - Copy.json"
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

using __IItQTY__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.QTY;
using __ItemSale1__ = global::ItemSaleHistoryJson - Copy.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson>;
using __IItDATED__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.DATED;
using __IItCUSTOMER__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.CUSTOMERS_NAME;
using __IItSUBTOTAL__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.SUBTOTAL;
using __IItUNITPRIC__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.UNITPRICE;
using __IItT_QUANTI__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.T_QUANTITY;
using __IItPCS_CTN__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.PCS_CTN;
using __IItITEM_NAM__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.ITEM_NAME;
using __IItITEM_COD__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.ITEM_CODE;
using __IItBILL_ID__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.BILL_ID;
using __Arr__ = global::Starcounter.Arr<global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson>;
using __ItemSale2__ = global::ItemSaleHistoryJson - Copy.Input;
using __ItItemSale2__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input;
using __ItItemSale1__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __IItSchema__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.JsonByExample.Schema;
using __ItItemSale__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson;
using __ItSchema__ = global::ItemSaleHistoryJson - Copy.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ItemSale__ = global::ItemSaleHistoryJson - Copy;
using __IItID__ = global::ItemSaleHistoryJson - Copy.ItemSaleHistoryElementJson.Input.ID;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ItemSaleHistoryJson - Copy : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ItSchema__ DefaultTemplate = new __ItSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemSaleHistoryJson - Copy() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemSaleHistoryJson - Copy(__ItSchema__ template) { Template = template; }
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
                ClassName = "ItemSaleHistoryJson - Copy";
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
#line 17 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.ItemSaleHistory.Getter(this); }
#line 17 "Server\Partials\ItemSaleHistoryJson - Copy.json"
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
        private System.Int64 __bf__ID__;
        private System.Int64 __bf__QTY__;
        private System.Int64 __bf__BILL_ID__;
        private System.String __bf__ITEM_CODE__;
        private System.String __bf__ITEM_NAME__;
        private System.Int64 __bf__PCS_CTN__;
        private System.Int64 __bf__T_QUANTITY__;
        private System.Int64 __bf__UNITPRICE__;
        private System.Int64 __bf__SUBTOTAL__;
        private System.String __bf__CUSTOMERS_NAME__;
        private System.String __bf__DATED__;
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
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    QTY = Add<__TLong__>("QTY");
                    QTY.DefaultValue = 0L;
                    QTY.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__QTY__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__QTY__ = (System.Int64)_v_; }, false);
                    BILL_ID = Add<__TLong__>("BILL_ID");
                    BILL_ID.DefaultValue = 0L;
                    BILL_ID.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__BILL_ID__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__BILL_ID__ = (System.Int64)_v_; }, false);
                    ITEM_CODE = Add<__TString__>("ITEM_CODE");
                    ITEM_CODE.DefaultValue = "";
                    ITEM_CODE.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__ITEM_CODE__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__ITEM_CODE__ = (System.String)_v_; }, false);
                    ITEM_NAME = Add<__TString__>("ITEM_NAME");
                    ITEM_NAME.DefaultValue = "";
                    ITEM_NAME.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__ITEM_NAME__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__ITEM_NAME__ = (System.String)_v_; }, false);
                    PCS_CTN = Add<__TLong__>("PCS_CTN");
                    PCS_CTN.DefaultValue = 0L;
                    PCS_CTN.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__PCS_CTN__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__PCS_CTN__ = (System.Int64)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    UNITPRICE = Add<__TLong__>("UNITPRICE");
                    UNITPRICE.DefaultValue = 0L;
                    UNITPRICE.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__UNITPRICE__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__UNITPRICE__ = (System.Int64)_v_; }, false);
                    SUBTOTAL = Add<__TLong__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = 0L;
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__SUBTOTAL__ = (System.Int64)_v_; }, false);
                    CUSTOMERS_NAME = Add<__TString__>("CUSTOMERS_NAME");
                    CUSTOMERS_NAME.DefaultValue = "";
                    CUSTOMERS_NAME.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__CUSTOMERS_NAME__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__CUSTOMERS_NAME__ = (System.String)_v_; }, false);
                    DATED = Add<__TString__>("DATED");
                    DATED.DefaultValue = "";
                    DATED.SetCustomAccessors((_p_) => { return ((__ItItemSale__)_p_).__bf__DATED__; }, (_p_, _v_) => { ((__ItItemSale__)_p_).__bf__DATED__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ItItemSale__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TLong__ QTY;
                public __TLong__ BILL_ID;
                public __TString__ ITEM_CODE;
                public __TString__ ITEM_NAME;
                public __TLong__ PCS_CTN;
                public __TLong__ T_QUANTITY;
                public __TLong__ UNITPRICE;
                public __TLong__ SUBTOTAL;
                public __TString__ CUSTOMERS_NAME;
                public __TString__ DATED;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 4 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 4 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY {
#line 5 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.QTY.Getter(this); }
#line 5 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.QTY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BILL_ID {
#line 6 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.BILL_ID.Getter(this); }
#line 6 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.BILL_ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ITEM_CODE {
#line 7 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.ITEM_CODE.Getter(this); }
#line 7 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.ITEM_CODE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ITEM_NAME {
#line 8 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.ITEM_NAME.Getter(this); }
#line 8 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.ITEM_NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 PCS_CTN {
#line 9 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.PCS_CTN.Getter(this); }
#line 9 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.PCS_CTN.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 10 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 10 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 UNITPRICE {
#line 11 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.UNITPRICE.Getter(this); }
#line 11 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.UNITPRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SUBTOTAL {
#line 12 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 12 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CUSTOMERS_NAME {
#line 13 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.CUSTOMERS_NAME.Getter(this); }
#line 13 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.CUSTOMERS_NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DATED {
#line 15 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    get {
#line hidden
        return Template.DATED.Getter(this); }
#line 15 "Server\Partials\ItemSaleHistoryJson - Copy.json"
    set {
#line hidden
        Template.DATED.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class QTY : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BILL_ID : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class ITEM_CODE : Input<__ItItemSale__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ITEM_NAME : Input<__ItItemSale__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PCS_CTN : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class UNITPRICE : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__ItItemSale__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class CUSTOMERS_NAME : Input<__ItItemSale__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class DATED : Input<__ItItemSale__, __TString__, string> {
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