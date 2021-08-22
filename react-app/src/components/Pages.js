import Name from "./pages/Name"
import SmallBox from "./pages/SmallBox"
import AbilityBox from "./pages/AbilityBox"

const Pages = ({ title }) => {
    return (
        <div className="page-container">
            {title === '1' && 
                <>
                    <Name name="Thorin, son of Grim"/> 
                    <SmallBox title="Class & Level" name="Ranger (8)"/>
                    <SmallBox title="Background" name="Soldier" />
                    <SmallBox title="Player name" name="Branko" />
                    <AbilityBox  name="ability" />
                    <AbilityBox name="health" />
                </>
            }
            {title === '2' && <h2>This is page 2</h2>}
            {title === '3' && <h2>This is page 3</h2>}
        </div>
    )
}

export default Pages
