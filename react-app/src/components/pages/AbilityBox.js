import Title from "./Title"

const AbilityBox = ({name}) => {
    return (
        <div className="ability-container">
            {name === 'ability' && <Title title="ABILITY SCORES:" />}
            {name === 'health' && <Title title="HEALTH:" />}
        </div>
    )
}

export default AbilityBox
