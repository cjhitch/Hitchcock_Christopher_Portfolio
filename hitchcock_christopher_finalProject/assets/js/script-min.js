!function(){let t=0;const e=document.querySelector("section.input-area"),s=["Item Name","Item Cost (only #'s ex. 12.34)","Weight/Quantity (only #'s ex. 2.45) This may be left blank"],n=["name","cost","quant"],c=["must be 2 characters or longer","must only be a number and at least 1 digit","must only be a number"];function i(){!function(){const n=document.createElement("article");n.setAttribute("class","col-md-4 col-sm-12"),n.setAttribute("id","item"+t),e.prepend(n),function(t){const e=document.createElement("div");e.setAttribute("class","col-sm-12"),t.appendChild(e);for(let t=0;t<s.length;t++)o(e,t),l(e,t),a(e,t);(function(t){const e=document.createElement("section");e.setAttribute("class","row"),t.appendChild(e);const s=document.createElement("button");s.setAttribute("class","calculate-total mx-auto mt-3"),s.setAttribute("disabled","true"),s.textContent="Calculate Total",e.appendChild(s)})(e),function(t){const e=document.createElement("section");e.setAttribute("class","row mt-3");const s=document.createElement("div");s.setAttribute("class","col-sm-5");const n=document.createElement("div");n.setAttribute("class","col-sm-7"),t.appendChild(e),e.appendChild(s),e.appendChild(n);const c=function(){const t=document.createElement("h6");return t.setAttribute("class","text-left"),t.textContent="Subtotal: $",t}(),i=function(t){const e=document.createElement("h6");return e.setAttribute("class","text-left"),e.textContent="Tax: $",e}(),o=function(t){const e=document.createElement("h5");return e.setAttribute("class","mt-3 text-left h5-item"),e.textContent="Total: $",e}();s.appendChild(c),s.appendChild(i),s.appendChild(o)}(e)}(n)}(),function(){document.querySelector("button");const e=document.querySelector("#item"+t).childNodes[0];(function(t,e){const s=t.childNodes[1],n=t.childNodes[2];s.addEventListener("input",function(){const t=s.value;""==t||t.length<2?(s.classList.add("error"),n.classList.remove("invisible"),s.classList.remove("success")):(s.classList.remove("error"),n.classList.add("invisible"),s.classList.add("success"))})})(e),function(t,e){const s=t.childNodes[4],n=t.childNodes[5];s.addEventListener("input",function(){const t=parseFloat(s.value);""==t||t.length<1||isNaN(t)?(s.classList.add("error"),n.classList.remove("invisible"),s.classList.remove("success")):(s.classList.remove("error"),n.classList.add("invisible"),s.classList.add("success"))})}(e),function(t,e){const s=t.childNodes[7],n=t.childNodes[8];s.addEventListener("input",function(){const t=parseFloat(s.value);""==s.value?(s.classList.remove("error"),n.classList.add("invisible"),s.classList.add("success")):""!=t&&(isNaN(t)?(s.classList.add("error"),n.classList.remove("invisible"),s.classList.remove("success")):(s.classList.remove("error"),n.classList.add("invisible"),s.classList.add("success")))})}(e),function(){const e=document.querySelector("#item"+t+" div"),s=e.childNodes[1],n=e.childNodes[4],c=e.childNodes[7],i=document.querySelector("button.calculate-total"),o={attributes:!0},l=new MutationObserver(function(t,e){for(let e of t)"attributes"==e.type&&(s.classList.contains("success")&&n.classList.contains("success")&&c.classList.contains("success")?i.removeAttribute("disabled"):i.setAttribute("disabled","true"))});l.observe(s,o),l.observe(n,o),l.observe(c,o)}()}(),t++}function o(t,e){const c=document.createElement("label");c.setAttribute("class","text-center d-block mt-3"),c.setAttribute("for","input-"+n[e]),c.textContent=s[e],t.appendChild(c)}function l(t,e){const s=document.createElement("input");s.setAttribute("class","w-100 input-"+n[e]),s.classList.contains("input-quant")&&s.setAttribute("class","w-100 success input-"+n[e]),s.setAttribute("type","text"),t.appendChild(s)}function a(t,e){const s=document.createElement("p");s.setAttribute("class","error-text invisible"),s.textContent=c[e],t.appendChild(s)}i(),document.querySelector("button#newItem").addEventListener("click",i)}();