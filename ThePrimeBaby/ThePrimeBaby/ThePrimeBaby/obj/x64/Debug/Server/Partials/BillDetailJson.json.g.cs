// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\BillDetailJson.json"
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

using __BBiID__ = global::BillDetailJson.BillDetailsElementJson.Input.ID;
using __BillDeta1__ = global::BillDetailJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::BillDetailJson.BillDetailsElementJson>;
using __BBiBill__ = global::BillDetailJson.BillDetailsElementJson.Input.Bill;
using __BBiItem__ = global::BillDetailJson.BillDetailsElementJson.Input.Item;
using __BBiCustomer__ = global::BillDetailJson.BillDetailsElementJson.Input.Customer;
using __BBiUNITPRIC__ = global::BillDetailJson.BillDetailsElementJson.Input.UNITPRICE;
using __BBiSUBTOTAL__ = global::BillDetailJson.BillDetailsElementJson.Input.SUBTOTAL;
using __BBiT_QUANTI__ = global::BillDetailJson.BillDetailsElementJson.Input.T_QUANTITY;
using __BBiPCS_CTN__ = global::BillDetailJson.BillDetailsElementJson.Input.PCS_CTN;
using __BBiQTY__ = global::BillDetailJson.BillDetailsElementJson.Input.QTY;
using __BBiName__ = global::BillDetailJson.BillDetailsElementJson.Input.Name;
using __Arr__ = global::Starcounter.Arr<global::BillDetailJson.BillDetailsElementJson>;
using __BillDeta2__ = global::BillDetailJson.Input;
using __BiBillDeta1__ = global::BillDetailJson.BillDetailsElementJson.JsonByExample;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __BBiSchema__ = global::BillDetailJson.BillDetailsElementJson.JsonByExample.Schema;
using __BiBillDeta__ = global::BillDetailJson.BillDetailsElementJson;
using __BiSchema__ = global::BillDetailJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __BillDeta__ = global::BillDetailJson;
using __BiBillDeta2__ = global::BillDetailJson.BillDetailsElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class BillDetailJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BiSchema__ DefaultTemplate = new __BiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillDetailJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillDetailJson(__BiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BiSchema__ Template { get { return (__BiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__BillDetails__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__BillDeta__);
                ClassName = "BillDetailJson";
                Properties.ClearExposed();
                BillDetails = Add<__TArray__>("BillDetails");
                BillDetails.SetCustomGetElementType((arr) => { return __BiBillDeta__.DefaultTemplate;});
                BillDetails.SetCustomAccessors((_p_) => { return ((__BillDeta__)_p_).__bf__BillDetails__; }, (_p_, _v_) => { ((__BillDeta__)_p_).__bf__BillDetails__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __BillDeta__(this) { Parent = parent }; }
            public __TArray__ BillDetails;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ BillDetails {
#line 14 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.BillDetails.Getter(this); }
#line 14 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.BillDetails.Setter(this, value); } }
#line default

    
    #line hidden
    public class BillDetailsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __BBiSchema__ DefaultTemplate = new __BBiSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillDetailsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillDetailsElementJson(__BBiSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __BBiSchema__ Template { get { return (__BBiSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__Name__;
        private System.Int64 __bf__QTY__;
        private System.Int64 __bf__PCS_CTN__;
        private System.Decimal __bf__T_QUANTITY__;
        private System.Decimal __bf__SUBTOTAL__;
        private System.Decimal __bf__UNITPRICE__;
        private System.String __bf__Customer__;
        private System.String __bf__Item__;
        private System.String __bf__Bill__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__BiBillDeta__);
                    ClassName = "BillDetailsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    QTY = Add<__TLong__>("QTY");
                    QTY.DefaultValue = 0L;
                    QTY.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__QTY__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__QTY__ = (System.Int64)_v_; }, false);
                    PCS_CTN = Add<__TLong__>("PCS_CTN");
                    PCS_CTN.DefaultValue = 0L;
                    PCS_CTN.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__PCS_CTN__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__PCS_CTN__ = (System.Int64)_v_; }, false);
                    T_QUANTITY = Add<__TDecimal__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0.0m;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__T_QUANTITY__ = (System.Decimal)_v_; }, false);
                    SUBTOTAL = Add<__TDecimal__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = 0.0m;
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__SUBTOTAL__ = (System.Decimal)_v_; }, false);
                    UNITPRICE = Add<__TDecimal__>("UNITPRICE");
                    UNITPRICE.DefaultValue = 0.0m;
                    UNITPRICE.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__UNITPRICE__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__UNITPRICE__ = (System.Decimal)_v_; }, false);
                    Customer = Add<__TString__>("Customer");
                    Customer.DefaultValue = "";
                    Customer.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__Customer__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__Customer__ = (System.String)_v_; }, false);
                    Item = Add<__TString__>("Item");
                    Item.DefaultValue = "";
                    Item.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__Item__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__Item__ = (System.String)_v_; }, false);
                    Bill = Add<__TString__>("Bill");
                    Bill.DefaultValue = "";
                    Bill.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__Bill__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__Bill__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiBillDeta__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ Name;
                public __TLong__ QTY;
                public __TLong__ PCS_CTN;
                public __TDecimal__ T_QUANTITY;
                public __TDecimal__ SUBTOTAL;
                public __TDecimal__ UNITPRICE;
                public __TString__ Customer;
                public __TString__ Item;
                public __TString__ Bill;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 4 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 4 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY {
#line 5 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.QTY.Getter(this); }
#line 5 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.QTY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 PCS_CTN {
#line 6 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.PCS_CTN.Getter(this); }
#line 6 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.PCS_CTN.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal T_QUANTITY {
#line 7 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 7 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal SUBTOTAL {
#line 8 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 8 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal UNITPRICE {
#line 9 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.UNITPRICE.Getter(this); }
#line 9 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.UNITPRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Customer {
#line 10 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.Customer.Getter(this); }
#line 10 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.Customer.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Item {
#line 11 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.Item.Getter(this); }
#line 11 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.Item.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Bill {
#line 13 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.Bill.Getter(this); }
#line 13 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.Bill.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class Name : Input<__BiBillDeta__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class QTY : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class PCS_CTN : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__BiBillDeta__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__BiBillDeta__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class UNITPRICE : Input<__BiBillDeta__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class Customer : Input<__BiBillDeta__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class Item : Input<__BiBillDeta__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class Bill : Input<__BiBillDeta__, __TString__, string> {
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