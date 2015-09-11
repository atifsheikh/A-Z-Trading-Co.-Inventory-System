// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ShipmentDetailJson.json"
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

using __SSSVeID__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.VendorJson.Input.ID;
using __SSShID__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.Input.ID;
using __SShItemJson__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ItemJson;
using __SShItemJson1__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ItemJson.JsonByExample;
using __SShItemJson2__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ItemJson.Input;
using __SSItCODE__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ItemJson.Input.CODE;
using __SSItMODEL__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ItemJson.Input.MODEL;
using __ShShipment2__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input;
using __SShID__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.ID;
using __SShNAME__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.NAME;
using __SShT_QUANTI__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.T_QUANTITY;
using __SShQTY_PER___ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.QTY_PER_BOX;
using __SShMODEL__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.MODEL;
using __SShCTN__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.CTN;
using __SShPRICE__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.PRICE;
using __SShSUBTOTAL__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.Input.SUBTOTAL;
using __TArray__ = global::Starcounter.Templates.TArray<global::ShipmentDetailJson.ShipmentDetailsElementJson>;
using __Shipment1__ = global::ShipmentDetailJson.JsonByExample;
using __SShShipment2__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.Input;
using __Arr__ = global::Starcounter.Arr<global::ShipmentDetailJson.ShipmentDetailsElementJson>;
using __Shipment2__ = global::ShipmentDetailJson.Input;
using __SSShVendorJs1__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.VendorJson.JsonByExample;
using __Shipment__ = global::ShipmentDetailJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __ShSchema__ = global::ShipmentDetailJson.JsonByExample.Schema;
using __ShShipment__ = global::ShipmentDetailJson.ShipmentDetailsElementJson;
using __SShSchema__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __SSShSchema__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.JsonByExample.Schema;
using __SSSVeSchema__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.VendorJson.JsonByExample.Schema;
using __SSItSchema__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ItemJson.JsonByExample.Schema;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __ShShipment1__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.JsonByExample;
using __SShShipment__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson;
using __SShShipment1__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.JsonByExample;
using __SSShVendorJs__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.VendorJson;
using __SSShVendorJs2__ = global::ShipmentDetailJson.ShipmentDetailsElementJson.ShipmentJson.VendorJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ShipmentDetailJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ShSchema__ DefaultTemplate = new __ShSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentDetailJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ShipmentDetailJson(__ShSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ShSchema__ Template { get { return (__ShSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__ShipmentDetails__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Shipment__);
                ClassName = "ShipmentDetailJson";
                Properties.ClearExposed();
                ShipmentDetails = Add<__TArray__>("ShipmentDetails");
                ShipmentDetails.SetCustomGetElementType((arr) => { return __ShShipment__.DefaultTemplate;});
                ShipmentDetails.SetCustomAccessors((_p_) => { return ((__Shipment__)_p_).__bf__ShipmentDetails__; }, (_p_, _v_) => { ((__Shipment__)_p_).__bf__ShipmentDetails__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Shipment__(this) { Parent = parent }; }
            public __TArray__ ShipmentDetails;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ ShipmentDetails {
#line 22 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.ShipmentDetails.Getter(this); }
#line 22 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.ShipmentDetails.Setter(this, value); } }
#line default

    
    #line hidden
    public class ShipmentDetailsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SShSchema__ DefaultTemplate = new __SShSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentDetailsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ShipmentDetailsElementJson(__SShSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SShSchema__ Template { get { return (__SShSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private __SShShipment__ __bf__Shipment__;
        private __SShItemJson__ __bf__Item__;
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
                    InstanceType = typeof(__ShShipment__);
                    ClassName = "ShipmentDetailsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    Shipment = Add<__SSShSchema__>("Shipment");
                    Shipment.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Shipment__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Shipment__ = (__SShShipment__)_v_; }, false);
                    Item = Add<__SSItSchema__>("Item");
                    Item.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__Item__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__Item__ = (__SShItemJson__)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    QTY_PER_BOX = Add<__TLong__>("QTY_PER_BOX");
                    QTY_PER_BOX.DefaultValue = 0L;
                    QTY_PER_BOX.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__QTY_PER_BOX__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__QTY_PER_BOX__ = (System.Int64)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    CTN = Add<__TLong__>("CTN");
                    CTN.DefaultValue = 0L;
                    CTN.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__CTN__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__CTN__ = (System.Int64)_v_; }, false);
                    PRICE = Add<__TDecimal__>("PRICE");
                    PRICE.DefaultValue = 0.0m;
                    PRICE.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__PRICE__ = (System.Decimal)_v_; }, false);
                    SUBTOTAL = Add<__TDecimal__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = 0.0m;
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__ShShipment__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__ShShipment__)_p_).__bf__SUBTOTAL__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ShShipment__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __SSShSchema__ Shipment;
                public __SSItSchema__ Item;
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
#line 3 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __SShShipment__ Shipment {
#line 10 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return (__SShShipment__)Template.Shipment.Getter(this); }
#line 10 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.Shipment.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __SShItemJson__ Item {
#line 14 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return (__SShItemJson__)Template.Item.Getter(this); }
#line 14 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.Item.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 15 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 15 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY_PER_BOX {
#line 16 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.QTY_PER_BOX.Getter(this); }
#line 16 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.QTY_PER_BOX.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 17 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 17 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 CTN {
#line 18 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.CTN.Getter(this); }
#line 18 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.CTN.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal PRICE {
#line 19 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 19 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal SUBTOTAL {
#line 21 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 21 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class ShipmentJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __SSShSchema__ DefaultTemplate = new __SSShSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public ShipmentJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public ShipmentJson(__SSShSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __SSShSchema__ Template { get { return (__SSShSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.Int64 __bf__ID__;
            private __SSShVendorJs__ __bf__Vendor__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__SShShipment__);
                        ClassName = "ShipmentJson";
                        Properties.ClearExposed();
                        ID = Add<__TLong__>("ID");
                        ID.DefaultValue = 0L;
                        ID.SetCustomAccessors((_p_) => { return ((__SShShipment__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__SShShipment__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        Vendor = Add<__SSSVeSchema__>("Vendor");
                        Vendor.SetCustomAccessors((_p_) => { return ((__SShShipment__)_p_).__bf__Vendor__; }, (_p_, _v_) => { ((__SShShipment__)_p_).__bf__Vendor__ = (__SSShVendorJs__)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __SShShipment__(this) { Parent = parent }; }
                    public __TLong__ ID;
                    public __SSSVeSchema__ Vendor;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ID {
#line 6 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 6 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public __SSShVendorJs__ Vendor {
#line 10 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return (__SSShVendorJs__)Template.Vendor.Getter(this); }
#line 10 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.Vendor.Setter(this, value); } }
#line default

            
            #line hidden
            public class VendorJson : __Json__ {
                #line hidden
                [_GEN2_("Starcounter","2.0")]
                public static __SSSVeSchema__ DefaultTemplate = new __SSSVeSchema__();
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public VendorJson() { }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public VendorJson(__SSSVeSchema__ template) { Template = template; }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public new __SSSVeSchema__ Template { get { return (__SSSVeSchema__)base.Template; } set { base.Template = value; } }
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
                            InstanceType = typeof(__SSShVendorJs__);
                            ClassName = "VendorJson";
                            Properties.ClearExposed();
                            ID = Add<__TLong__>("ID");
                            ID.DefaultValue = 0L;
                            ID.SetCustomAccessors((_p_) => { return ((__SSShVendorJs__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__SSShVendorJs__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        }
                        public override object CreateInstance(s.Json parent) { return new __SSShVendorJs__(this) { Parent = parent }; }
                        public __TLong__ ID;
                    }
                    #line default
                }
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.Int64 ID {
#line 9 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 9 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public static class Input {
                    
                    #line hidden
                    public class ID : Input<__SSShVendorJs__, __TLong__, long> {
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
                public class ID : Input<__SShShipment__, __TLong__, long> {
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
            public static __SSItSchema__ DefaultTemplate = new __SSItSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public ItemJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public ItemJson(__SSItSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __SSItSchema__ Template { get { return (__SSItSchema__)base.Template; } set { base.Template = value; } }
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
                        InstanceType = typeof(__SShItemJson__);
                        ClassName = "ItemJson";
                        Properties.ClearExposed();
                        CODE = Add<__TString__>("CODE");
                        CODE.DefaultValue = "";
                        CODE.SetCustomAccessors((_p_) => { return ((__SShItemJson__)_p_).__bf__CODE__; }, (_p_, _v_) => { ((__SShItemJson__)_p_).__bf__CODE__ = (System.String)_v_; }, false);
                        MODEL = Add<__TString__>("MODEL");
                        MODEL.DefaultValue = "";
                        MODEL.SetCustomAccessors((_p_) => { return ((__SShItemJson__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__SShItemJson__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __SShItemJson__(this) { Parent = parent }; }
                    public __TString__ CODE;
                    public __TString__ MODEL;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String CODE {
#line 12 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.CODE.Getter(this); }
#line 12 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.CODE.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String MODEL {
#line 14 "Server\Partials\ShipmentDetailJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 14 "Server\Partials\ShipmentDetailJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class CODE : Input<__SShItemJson__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class MODEL : Input<__SShItemJson__, __TString__, string> {
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
            public class ID : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class QTY_PER_BOX : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class MODEL : Input<__ShShipment__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CTN : Input<__ShShipment__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class PRICE : Input<__ShShipment__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__ShShipment__, __TDecimal__, Decimal> {
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