import Name from "./pages/Name"
import SmallBox from "./pages/SmallBox"

const Pages = ({ title }) => {
    return (
        <div className="page-container">
            {title === '1' && 
                <>
                    <Name name="Thorin, son of Grim"/> 
                    <SmallBox title="Class & Level" name="Ranger (8)"/>
                </>
            }
            {title === '2' && <h2>This is page 2</h2>}
            {title === '3' && <h2>This is page 3</h2>}
        </div>
    )
}

export default Pages
