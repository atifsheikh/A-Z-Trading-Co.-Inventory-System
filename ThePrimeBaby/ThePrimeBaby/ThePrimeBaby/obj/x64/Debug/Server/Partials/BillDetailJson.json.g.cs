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

using __BBBCuID__ = global::BillDetailJson.BillDetailsElementJson.BillJson.CustomerJson.Input.ID;
using __BBBiID__ = global::BillDetailJson.BillDetailsElementJson.BillJson.Input.ID;
using __BBiItemJson__ = global::BillDetailJson.BillDetailsElementJson.ItemJson;
using __BBiItemJson1__ = global::BillDetailJson.BillDetailsElementJson.ItemJson.JsonByExample;
using __BBiItemJson2__ = global::BillDetailJson.BillDetailsElementJson.ItemJson.Input;
using __BBItCODE__ = global::BillDetailJson.BillDetailsElementJson.ItemJson.Input.CODE;
using __BBItMODEL__ = global::BillDetailJson.BillDetailsElementJson.ItemJson.Input.MODEL;
using __BiBillDeta2__ = global::BillDetailJson.BillDetailsElementJson.Input;
using __BBiID__ = global::BillDetailJson.BillDetailsElementJson.Input.ID;
using __BBiNAME__ = global::BillDetailJson.BillDetailsElementJson.Input.NAME;
using __BBiT_QUANTI__ = global::BillDetailJson.BillDetailsElementJson.Input.T_QUANTITY;
using __BBiQTY_PER___ = global::BillDetailJson.BillDetailsElementJson.Input.QTY_PER_BOX;
using __BBiMODEL__ = global::BillDetailJson.BillDetailsElementJson.Input.MODEL;
using __BBiCTN__ = global::BillDetailJson.BillDetailsElementJson.Input.CTN;
using __BBiPRICE__ = global::BillDetailJson.BillDetailsElementJson.Input.PRICE;
using __BBiSUBTOTAL__ = global::BillDetailJson.BillDetailsElementJson.Input.SUBTOTAL;
using __TArray__ = global::Starcounter.Templates.TArray<global::BillDetailJson.BillDetailsElementJson>;
using __BillDeta1__ = global::BillDetailJson.JsonByExample;
using __BBiBillJson2__ = global::BillDetailJson.BillDetailsElementJson.BillJson.Input;
using __Arr__ = global::Starcounter.Arr<global::BillDetailJson.BillDetailsElementJson>;
using __BillDeta2__ = global::BillDetailJson.Input;
using __BBBiCustomer1__ = global::BillDetailJson.BillDetailsElementJson.BillJson.CustomerJson.JsonByExample;
using __BillDeta__ = global::BillDetailJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __BiSchema__ = global::BillDetailJson.JsonByExample.Schema;
using __BiBillDeta__ = global::BillDetailJson.BillDetailsElementJson;
using __BBiSchema__ = global::BillDetailJson.BillDetailsElementJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __BBBiSchema__ = global::BillDetailJson.BillDetailsElementJson.BillJson.JsonByExample.Schema;
using __BBBCuSchema__ = global::BillDetailJson.BillDetailsElementJson.BillJson.CustomerJson.JsonByExample.Schema;
using __BBItSchema__ = global::BillDetailJson.BillDetailsElementJson.ItemJson.JsonByExample.Schema;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __BiBillDeta1__ = global::BillDetailJson.BillDetailsElementJson.JsonByExample;
using __BBiBillJson__ = global::BillDetailJson.BillDetailsElementJson.BillJson;
using __BBiBillJson1__ = global::BillDetailJson.BillDetailsElementJson.BillJson.JsonByExample;
using __BBBiCustomer__ = global::BillDetailJson.BillDetailsElementJson.BillJson.CustomerJson;
using __BBBiCustomer2__ = global::BillDetailJson.BillDetailsElementJson.BillJson.CustomerJson.Input;

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
#line 22 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.BillDetails.Getter(this); }
#line 22 "Server\Partials\BillDetailJson.json"
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
        private System.String __bf__NAME__;
        private __BBiBillJson__ __bf__Bill__;
        private __BBiItemJson__ __bf__Item__;
        private System.Int64 __bf__T_QUANTITY__;
        private System.Int64 __bf__QTY_PER_BOX__;
        private System.String __bf__MODEL__;
        private System.Int64 __bf__CTN__;
        private System.Decimal __bf__PRICE__;
        private System.Decimal __bf__SUBTOTAL__;
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
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    Bill = Add<__BBBiSchema__>("Bill");
                    Bill.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__Bill__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__Bill__ = (__BBiBillJson__)_v_; }, false);
                    Item = Add<__BBItSchema__>("Item");
                    Item.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__Item__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__Item__ = (__BBiItemJson__)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    QTY_PER_BOX = Add<__TLong__>("QTY_PER_BOX");
                    QTY_PER_BOX.DefaultValue = 0L;
                    QTY_PER_BOX.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__QTY_PER_BOX__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__QTY_PER_BOX__ = (System.Int64)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    CTN = Add<__TLong__>("CTN");
                    CTN.DefaultValue = 0L;
                    CTN.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__CTN__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__CTN__ = (System.Int64)_v_; }, false);
                    PRICE = Add<__TDecimal__>("PRICE");
                    PRICE.DefaultValue = 0.0m;
                    PRICE.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__PRICE__ = (System.Decimal)_v_; }, false);
                    SUBTOTAL = Add<__TDecimal__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = 0.0m;
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__SUBTOTAL__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiBillDeta__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __BBBiSchema__ Bill;
                public __BBItSchema__ Item;
                public __TLong__ T_QUANTITY;
                public __TLong__ QTY_PER_BOX;
                public __TString__ MODEL;
                public __TLong__ CTN;
                public __TDecimal__ PRICE;
                public __TDecimal__ SUBTOTAL;
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
        public System.String NAME {
#line 4 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __BBiBillJson__ Bill {
#line 10 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return (__BBiBillJson__)Template.Bill.Getter(this); }
#line 10 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.Bill.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __BBiItemJson__ Item {
#line 14 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return (__BBiItemJson__)Template.Item.Getter(this); }
#line 14 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.Item.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 15 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 15 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY_PER_BOX {
#line 16 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.QTY_PER_BOX.Getter(this); }
#line 16 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.QTY_PER_BOX.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 17 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 17 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 CTN {
#line 18 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.CTN.Getter(this); }
#line 18 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.CTN.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal PRICE {
#line 19 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 19 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal SUBTOTAL {
#line 21 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 21 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class BillJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __BBBiSchema__ DefaultTemplate = new __BBBiSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public BillJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public BillJson(__BBBiSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __BBBiSchema__ Template { get { return (__BBBiSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.Int64 __bf__ID__;
            private __BBBiCustomer__ __bf__Customer__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__BBiBillJson__);
                        ClassName = "BillJson";
                        Properties.ClearExposed();
                        ID = Add<__TLong__>("ID");
                        ID.DefaultValue = 0L;
                        ID.SetCustomAccessors((_p_) => { return ((__BBiBillJson__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BBiBillJson__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        Customer = Add<__BBBCuSchema__>("Customer");
                        Customer.SetCustomAccessors((_p_) => { return ((__BBiBillJson__)_p_).__bf__Customer__; }, (_p_, _v_) => { ((__BBiBillJson__)_p_).__bf__Customer__ = (__BBBiCustomer__)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __BBiBillJson__(this) { Parent = parent }; }
                    public __TLong__ ID;
                    public __BBBCuSchema__ Customer;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ID {
#line 6 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 6 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public __BBBiCustomer__ Customer {
#line 10 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return (__BBBiCustomer__)Template.Customer.Getter(this); }
#line 10 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.Customer.Setter(this, value); } }
#line default

            
            #line hidden
            public class CustomerJson : __Json__ {
                #line hidden
                [_GEN2_("Starcounter","2.0")]
                public static __BBBCuSchema__ DefaultTemplate = new __BBBCuSchema__();
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public CustomerJson() { }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public CustomerJson(__BBBCuSchema__ template) { Template = template; }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public new __BBBCuSchema__ Template { get { return (__BBBCuSchema__)base.Template; } set { base.Template = value; } }
                public override bool IsCodegenerated { get { return true; } }
                private System.Int64 __bf__ID__;
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public static class JsonByExample {
                    
                    #line hidden
                    public class Schema : __TObject__ {
                        public Schema()
                            : base() {
                            InstanceType = typeof(__BBBiCustomer__);
                            ClassName = "CustomerJson";
                            Properties.ClearExposed();
                            ID = Add<__TLong__>("ID");
                            ID.DefaultValue = 0L;
                            ID.SetCustomAccessors((_p_) => { return ((__BBBiCustomer__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BBBiCustomer__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        }
                        public override object CreateInstance(s.Json parent) { return new __BBBiCustomer__(this) { Parent = parent }; }
                        public __TLong__ ID;
                    }
                    #line default
                }
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.Int64 ID {
#line 9 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 9 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public static class Input {
                    
                    #line hidden
                    public class ID : Input<__BBBiCustomer__, __TLong__, long> {
                    }
                    #line default
                }
                #line default
            }
            #line default
            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class ID : Input<__BBiBillJson__, __TLong__, long> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class ItemJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __BBItSchema__ DefaultTemplate = new __BBItSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public ItemJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public ItemJson(__BBItSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __BBItSchema__ Template { get { return (__BBItSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.String __bf__CODE__;
            private System.String __bf__MODEL__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__BBiItemJson__);
                        ClassName = "ItemJson";
                        Properties.ClearExposed();
                        CODE = Add<__TString__>("CODE");
                        CODE.DefaultValue = "";
                        CODE.SetCustomAccessors((_p_) => { return ((__BBiItemJson__)_p_).__bf__CODE__; }, (_p_, _v_) => { ((__BBiItemJson__)_p_).__bf__CODE__ = (System.String)_v_; }, false);
                        MODEL = Add<__TString__>("MODEL");
                        MODEL.DefaultValue = "";
                        MODEL.SetCustomAccessors((_p_) => { return ((__BBiItemJson__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__BBiItemJson__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __BBiItemJson__(this) { Parent = parent }; }
                    public __TString__ CODE;
                    public __TString__ MODEL;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String CODE {
#line 12 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.CODE.Getter(this); }
#line 12 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.CODE.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String MODEL {
#line 14 "Server\Partials\BillDetailJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 14 "Server\Partials\BillDetailJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class CODE : Input<__BBiItemJson__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class MODEL : Input<__BBiItemJson__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__BiBillDeta__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class QTY_PER_BOX : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class MODEL : Input<__BiBillDeta__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CTN : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class PRICE : Input<__BiBillDeta__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__BiBillDeta__, __TDecimal__, Decimal> {
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