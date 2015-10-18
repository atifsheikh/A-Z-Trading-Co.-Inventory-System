// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ItemShipmentHistoryJson.json"
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

using __IItSHIP_ID__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.SHIP_ID;
using __ItemShip1__ = global::ItemShipmentHistoryJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson>;
using __IItDATED__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.DATED;
using __IItSUBTOTAL__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.SUBTOTAL;
using __IItPRICE__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.PRICE;
using __IItT_QUANTI__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.T_QUANTITY;
using __IItQTY_PER___ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.QTY_PER_BOX;
using __IItCTN__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.CTN;
using __IItMODEL__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.MODEL;
using __IItITEM_COD__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input.ITEM_CODE;
using __Arr__ = global::Starcounter.Arr<global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson>;
using __ItemShip2__ = global::ItemShipmentHistoryJson.Input;
using __ItItemShip1__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __IItSchema__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.JsonByExample.Schema;
using __ItItemShip__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson;
using __ItSchema__ = global::ItemShipmentHistoryJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ItemShip__ = global::ItemShipmentHistoryJson;
using __ItItemShip2__ = global::ItemShipmentHistoryJson.ItemShipmentHistoryElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ItemShipmentHistoryJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ItSchema__ DefaultTemplate = new __ItSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemShipmentHistoryJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemShipmentHistoryJson(__ItSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ItSchema__ Template { get { return (__ItSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__ItemShipmentHistory__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ItemShip__);
                ClassName = "ItemShipmentHistoryJson";
                Properties.ClearExposed();
                ItemShipmentHistory = Add<__TArray__>("ItemShipmentHistory");
                ItemShipmentHistory.SetCustomGetElementType((arr) => { return __ItItemShip__.DefaultTemplate;});
                ItemShipmentHistory.SetCustomAccessors((_p_) => { return ((__ItemShip__)_p_).__bf__ItemShipmentHistory__; }, (_p_, _v_) => { ((__ItemShip__)_p_).__bf__ItemShipmentHistory__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ItemShip__(this) { Parent = parent }; }
            public __TArray__ ItemShipmentHistory;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ ItemShipmentHistory {
#line 15 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.ItemShipmentHistory.Getter(this); }
#line 15 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.ItemShipmentHistory.Setter(this, value); } }
#line default

    
    #line hidden
    public class ItemShipmentHistoryElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __IItSchema__ DefaultTemplate = new __IItSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemShipmentHistoryElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemShipmentHistoryElementJson(__IItSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __IItSchema__ Template { get { return (__IItSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__SHIP_ID__;
        private System.String __bf__ITEM_CODE__;
        private System.String __bf__MODEL__;
        private System.Int64 __bf__CTN__;
        private System.Int64 __bf__QTY_PER_BOX__;
        private System.Int64 __bf__T_QUANTITY__;
        private System.String __bf__PRICE__;
        private System.String __bf__SUBTOTAL__;
        private System.String __bf__DATED__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ItItemShip__);
                    ClassName = "ItemShipmentHistoryElementJson";
                    Properties.ClearExposed();
                    SHIP_ID = Add<__TLong__>("SHIP_ID");
                    SHIP_ID.DefaultValue = 0L;
                    SHIP_ID.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__SHIP_ID__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__SHIP_ID__ = (System.Int64)_v_; }, false);
                    ITEM_CODE = Add<__TString__>("ITEM_CODE");
                    ITEM_CODE.DefaultValue = "";
                    ITEM_CODE.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__ITEM_CODE__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__ITEM_CODE__ = (System.String)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    CTN = Add<__TLong__>("CTN");
                    CTN.DefaultValue = 0L;
                    CTN.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__CTN__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__CTN__ = (System.Int64)_v_; }, false);
                    QTY_PER_BOX = Add<__TLong__>("QTY_PER_BOX");
                    QTY_PER_BOX.DefaultValue = 0L;
                    QTY_PER_BOX.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__QTY_PER_BOX__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__QTY_PER_BOX__ = (System.Int64)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    PRICE = Add<__TString__>("PRICE");
                    PRICE.DefaultValue = "";
                    PRICE.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__PRICE__ = (System.String)_v_; }, false);
                    SUBTOTAL = Add<__TString__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = "";
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__SUBTOTAL__ = (System.String)_v_; }, false);
                    DATED = Add<__TString__>("DATED");
                    DATED.DefaultValue = "";
                    DATED.SetCustomAccessors((_p_) => { return ((__ItItemShip__)_p_).__bf__DATED__; }, (_p_, _v_) => { ((__ItItemShip__)_p_).__bf__DATED__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ItItemShip__(this) { Parent = parent }; }
                public __TLong__ SHIP_ID;
                public __TString__ ITEM_CODE;
                public __TString__ MODEL;
                public __TLong__ CTN;
                public __TLong__ QTY_PER_BOX;
                public __TLong__ T_QUANTITY;
                public __TString__ PRICE;
                public __TString__ SUBTOTAL;
                public __TString__ DATED;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SHIP_ID {
#line 4 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.SHIP_ID.Getter(this); }
#line 4 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.SHIP_ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ITEM_CODE {
#line 5 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.ITEM_CODE.Getter(this); }
#line 5 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.ITEM_CODE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 6 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 6 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 CTN {
#line 7 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.CTN.Getter(this); }
#line 7 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.CTN.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY_PER_BOX {
#line 8 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.QTY_PER_BOX.Getter(this); }
#line 8 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.QTY_PER_BOX.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 9 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 9 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PRICE {
#line 10 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 10 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String SUBTOTAL {
#line 11 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 11 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DATED {
#line 13 "Server\Partials\ItemShipmentHistoryJson.json"
    get {
#line hidden
        return Template.DATED.Getter(this); }
#line 13 "Server\Partials\ItemShipmentHistoryJson.json"
    set {
#line hidden
        Template.DATED.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class SHIP_ID : Input<__ItItemShip__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class ITEM_CODE : Input<__ItItemShip__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class MODEL : Input<__ItItemShip__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CTN : Input<__ItItemShip__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class QTY_PER_BOX : Input<__ItItemShip__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__ItItemShip__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class PRICE : Input<__ItItemShip__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__ItItemShip__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class DATED : Input<__ItItemShip__, __TString__, string> {
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