const html = window.igTemplating.html;
igRegisterScript("gridEmptyGridTemplateScript", (ctx) => {
    return html`
        <div customer_details-scope class="row-layout group_16">
            <p customer_details-scope class="typography__body-1 text_7">
                No order details avaialble.
            </p>
        </div>
    `
}, false);
