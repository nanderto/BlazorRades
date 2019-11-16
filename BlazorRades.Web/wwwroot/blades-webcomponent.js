class BladeHostElement extends HTMLElement {
    // property
    // .. showBreadCrumb
    // .. allowMultipleStacks

    constructor() {
        super();

        const shadowRoot = this.attachShadow({ mode: 'open' });
        shadowRoot.innerHTML = `
        <style>
            .blade-host-element {
                position: absolute;
                left:0px;
                top:0px;
                height: 100%;
                width: 100%;
            }
        </style>

        <div id="blade-host-element" class="blade-host-element">
            <slot id="blade-stack-slot"></slot>
        </div>
        `;
    }
    connectedCallback() {
    }
    disconnectedCallback() {

    }
    attributeChangedCallback(attrName, oldVal, newVal) {
    }

    get stacks() {
        return this.shadowRoot.getElementById("blade-stack-slot").assignedNodes().filter(n => n.nodeName == "BLADE-STACK");
    }
}

class BladeStackElement extends HTMLElement {
    constructor() {
        super();

        const shadowRoot = this.attachShadow({ mode: 'open' });
        shadowRoot.innerHTML = `
        <style>
            .blade-stack-element {
                position: absolute;
                left:0px;
                top:0px;
                height: 100%;
                width: 100%;
                display:flex;
                flex-direction: row;
                flex-wrap: nowrap;
                align-items: stretch;
                overflow-x: auto;
            }
        </style>
        <div id="blade-stack-element" class="blade-stack-element">
            <slot id="blade-slot"></slot>
        </div>
        `;
    }
    connectedCallback() {
    }
    disconnectedCallback() {

    }
    attributeChangedCallback(attrName, oldVal, newVal) {
    }

    get blades() {
        return this.shadowRoot.getElementById("blade-slot").assignedNodes().filter(n => n.nodeName == "BLADE-BLADE");
    }
}

class BladeBladeElement extends HTMLElement {
    // property
    // .. title
    // .. subTitle
    // .. icon
    // .. allowFullScreen
    // .. min-width

    // functions
    // .. close

    // event
    // .. closed (closes all later)

    static get observedAttributes() {
        return ['title', 'sub-title', 'icon'];
    }

    constructor() {
        super(); // always call super() first in the constructor.

        this._closedEvent = new CustomEvent("closed", {
            bubbles: true,
            cancelable: false,
        });

        const shadowRoot = this.attachShadow({ mode: 'open' });
        shadowRoot.innerHTML = `
        <style>
            .blade-blade-element {
                position: relative;
                
                background-color:white;
                height:100%;
                min-width:200px;

                display:flex;
                flex-direction: column;
                box-shadow: -1px 0px 2px 0px rgba(0,0,0,0.5);
            }

            .blade-blade-element header {
                position:relative;
                height: 48px;
                
                padding: 8px;
                padding-left:24px;
                border-top:1px solid lightgray; 
                border-bottom:1px solid lightgray;
                font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                flex-basis: 0;
                flex-shrink:0;
                flex-basis: 48px;
            }

            .blade-blade-element header button#close {
                position: absolute;
                top:0px;
                right:0px;
                background-color:inherit;
                border:0px;
                height:24px;
                width:24px;
            }

            .blade-blade-element header button#close:hover {
                background-color:red;
            }

            .blade-blade-element header div#icon {
                position: relative;
                float:left;
                height:48px;
                width:48px;
                vertical-align: center;
                font-size:32px;
            }

            .blade-blade-element header div#icon:empty {
                display:none;
            }

            .blade-blade-element header h2#title {
                text-overflow: ellipsis;
                white-space: nowrap;
                overflow:hidden;

                margin:0px;
                margin-right:1em;
                font-weight: normal;
                font-size:1.4em;
            }

            .blade-blade-element header small#sub-title {
                text-overflow: ellipsis;
                white-space: nowrap;
                overflow:hidden;

                margin:0px;
                margin-right:1em;
                font-size:0.6em;
                color: grey;
            }
            .blade-blade-element #content {
                overflow-y: auto;
                padding:8px;
                padding-left:24px;
            }
            .blade-command-bar-element {
                
                padding-left:24px;
                padding-right:8px;
                border-bottom:1px solid lightgray;
            }

            .blade-command-bar-element ::slotted(button) {
                height:100%;
                background-color: inherit;
                border:0px;
                height:2.5em;
            }

            .blade-command-bar-element ::slotted(button:hover) {
                background-color: whitesmoke;
            }
        </style>
        <div class="blade-blade-element">
            <header>
                <div id="icon"></div>
                <h2 id="title"></h2>
                <small id="sub-title"></small>
                <button id="close">X</button>
            </header>
            <div class="blade-command-bar-element">
                <slot name="blade-buttons"></slot>
            </div>
            <div id="content">
            <slot></slot>
            </div>
        </div>
        `;
    }
    connectedCallback() {
        this.shadowRoot.getElementById('close').addEventListener('click', _ => this.close());

        let previous = this.previousSibling;

        while (previous != null && previous.nodeName != "BLADE-BLADE") {
            previous = previous.previousSibling;
        }

        if (previous != null) {
            previous.addEventListener("closed", () => this.close());
        }
    }
    disconnectedCallback() {
    }
    attributeChangedCallback(attrName, oldVal, newVal) {
        this.renderAttributePassThrough(attrName, newVal);
    }


    get title() {
        return this.getAttribute("title");
    }
    set title(val) {
        this.setAttribute("title", val);
    }

    get subTitle() {
        return this.getAttribute("sub-title");
    }
    set subTitle(val) {
        this.setAttribute("sub-title", val);
    }

    get icon() {
        return this.getAttribute("icon");
    }
    set icon(val) {
        this.setAttribute("icon", val);
    }

    close() {
        this.dispatchEvent(this._closedEvent);
        this.remove();
    }

    renderAttributePassThrough(attrName, newVal) {
        const element = this.shadowRoot.getElementById(attrName);

        if (element) {
            element.innerHTML = newVal;
        }
    }
}

window.customElements.define('blade-host', BladeHostElement);
window.customElements.define('blade-stack', BladeStackElement);
window.customElements.define('blade-blade', BladeBladeElement);