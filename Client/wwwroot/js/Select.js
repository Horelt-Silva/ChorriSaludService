export function SelectUi(divElement) {
    const select = new Select(divElement);
     select.Render();
}
class Select {
    constructor(dropDownSelect) {
        this.dropDownSelect = dropDownSelect;
    }
    CloseLi() {
        const i = document.createElement("i")
        i.classList.add("bi", "bi-x");

        return i;

    }
    GetList() {
        const list = this.dropDownSelect.querySelector(".dropdown-items");
        const items = list.querySelectorAll("li");
        return { "list": list, "items": items };

    }
    GetButton() {
        const up = this.dropDownSelect.querySelector(".bi-chevron-compact-right");
        const down = this.dropDownSelect.querySelector(".bi-chevron-compact-left");
        return [up, down];
        //- {"up":up,"down":down};
    }
   Render() {
        //- const list=this.GetList();
        const btns = this.GetButton();
        const list = this.GetList();
        console.log(btns)
        const open = () => {
            this.dropDownSelect.classList.remove("inactive");
            list.list.classList.add("open");
            btns[0].style.display = "none";
            btns[1].style.display = "unset";
        }
        const close = () => {
            this.dropDownSelect.classList.add("inactive");
            btns[0].style.display = "unset";
            btns[1].style.display = "none";
        }
        btns[0].onclick =() => {
           open();
        }
        btns[1].onclick = () => {
            close();
        }
        list.items.forEach((li, index) => {
            const closeLi = this.CloseLi()
            li.onclick = () => {
                const liClone = li.cloneNode(true)
                liClone.classList.add("added");
                liClone.appendChild(closeLi);

                this.dropDownSelect.appendChild(liClone);
                li.remove();
                console.log(list.items.length - 1)
                console.log(index);
                if (index == list.items.length - 1) {
                    close();
                }
                closeLi.onclick = () => {
                    liClone.remove();
                    list.list.appendChild(li);
                }

            }
        })


    }
}

//export const SelectUi = () => {
//    document.querySelectorAll(".dropdown-select").forEach((s) => {
//        const sel = new Select(s);
//        console.log("aqui estoy");
//        sel.Render();
//        console.log("me ejecuto o no");
//    })

//}
//SelectUi();
