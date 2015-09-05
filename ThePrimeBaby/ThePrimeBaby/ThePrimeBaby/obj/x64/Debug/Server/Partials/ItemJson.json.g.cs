// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ItemJson.json"
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

using __IItID__ = global::ItemJson.ItemsElementJson.Input.ID;
using __ItemJson1__ = global::ItemJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ItemJson.ItemsElementJson>;
using __IItCategory__ = global::ItemJson.ItemsElementJson.Input.Category;
using __IItT_QUANTI__ = global::ItemJson.ItemsElementJson.Input.T_QUANTITY;
using __IItCODE__ = global::ItemJson.ItemsElementJson.Input.CODE;
using __IItMODEL__ = global::ItemJson.ItemsElementJson.Input.MODEL;
using __IItIMAGE__ = global::ItemJson.ItemsElementJson.Input.IMAGE;
using __IItPRICE__ = global::ItemJson.ItemsElementJson.Input.PRICE;
using __IItCOSTPRIC__ = global::ItemJson.ItemsElementJson.Input.COSTPRICE;
using __IItQTY_BOX__ = global::ItemJson.ItemsElementJson.Input.QTY_BOX;
using __IItName__ = global::ItemJson.ItemsElementJson.Input.Name;
using __Arr__ = global::Starcounter.Arr<global::ItemJson.ItemsElementJson>;
using __ItemJson2__ = global::ItemJson.Input;
using __ItItemsEle1__ = global::ItemJson.ItemsElementJson.JsonByExample;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __IItSchema__ = global::ItemJson.ItemsElementJson.JsonByExample.Schema;
using __ItItemsEle__ = global::ItemJson.ItemsElementJson;
using __ItSchema__ = global::ItemJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ItemJson__ = global::ItemJson;
using __ItItemsEle2__ = global::ItemJson.ItemsElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ItemJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ItSchema__ DefaultTemplate = new __ItSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemJson(__ItSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ItSchema__ Template { get { return (__ItSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Items__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ItemJson__);
                ClassName = "ItemJson";
                Properties.ClearExposed();
                Items = Add<__TArray__>("Items");
                Items.SetCustomGetElementType((arr) => { return __ItItemsEle__.DefaultTemplate;});
                Items.SetCustomAccessors((_p_) => { return ((__ItemJson__)_p_).__bf__Items__; }, (_p_, _v_) => { ((__ItemJson__)_p_).__bf__Items__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ItemJson__(this) { Parent = parent }; }
            public __TArray__ Items;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Items {
#line 14 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.Items.Getter(this); }
#line 14 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.Items.Setter(this, value); } }
#line default

    
    #line hidden
    public class ItemsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __IItSchema__ DefaultTemplate = new __IItSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemsElementJson(__IItSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __IItSchema__ Template { get { return (__IItSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__Name__;
        private System.Int64 __bf__QTY_BOX__;
        private System.Decimal __bf__COSTPRICE__;
        private System.Decimal __bf__PRICE__;
        private System.String __bf__IMAGE__;
        private System.String __bf__MODEL__;
        private System.String __bf__CODE__;
        private System.Int64 __bf__T_QUANTITY__;
        private System.String __bf__Category__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ItItemsEle__);
                    ClassName = "ItemsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    QTY_BOX = Add<__TLong__>("QTY_BOX");
                    QTY_BOX.DefaultValue = 0L;
                    QTY_BOX.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__QTY_BOX__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__QTY_BOX__ = (System.Int64)_v_; }, false);
                    COSTPRICE = Add<__TDecimal__>("COSTPRICE");
                    COSTPRICE.DefaultValue = 0.0m;
                    COSTPRICE.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__COSTPRICE__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__COSTPRICE__ = (System.Decimal)_v_; }, false);
                    PRICE = Add<__TDecimal__>("PRICE");
                    PRICE.DefaultValue = 0.0m;
                    PRICE.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__PRICE__ = (System.Decimal)_v_; }, false);
                    IMAGE = Add<__TString__>("IMAGE");
                    IMAGE.DefaultValue = "";
                    IMAGE.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__IMAGE__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__IMAGE__ = (System.String)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    CODE = Add<__TString__>("CODE");
                    CODE.DefaultValue = "";
                    CODE.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__CODE__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__CODE__ = (System.String)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    Category = Add<__TString__>("Category");
                    Category.DefaultValue = "";
                    Category.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__Category__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__Category__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ItItemsEle__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ Name;
                public __TLong__ QTY_BOX;
                public __TDecimal__ COSTPRICE;
                public __TDecimal__ PRICE;
                public __TString__ IMAGE;
                public __TString__ MODEL;
                public __TString__ CODE;
                public __TLong__ T_QUANTITY;
                public __TString__ Category;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 4 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 4 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY_BOX {
#line 5 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.QTY_BOX.Getter(this); }
#line 5 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.QTY_BOX.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal COSTPRICE {
#line 6 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.COSTPRICE.Getter(this); }
#line 6 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.COSTPRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal PRICE {
#line 7 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 7 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String IMAGE {
#line 8 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.IMAGE.Getter(this); }
#line 8 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.IMAGE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 9 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 9 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CODE {
#line 10 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.CODE.Getter(this); }
#line 10 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.CODE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 11 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 11 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Category {
#line 13 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.Category.Getter(this); }
#line 13 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.Category.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__ItItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class Name : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class QTY_BOX : Input<__ItItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class COSTPRICE : Input<__ItItemsEle__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class PRICE : Input<__ItItemsEle__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class IMAGE : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class MODEL : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CODE : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__ItItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class Category : Input<__ItItemsEle__, __TString__, string> {
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